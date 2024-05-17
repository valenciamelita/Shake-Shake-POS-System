
DROP PROCEDURE IF EXISTS PLaporanpenjualan;
DELIMITER //

CREATE PROCEDURE PLaporanpenjualan(IN interval_type VARCHAR(10))
BEGIN
    DECLARE start_date DATE;
    DECLARE end_date DATE;

    IF interval_type = 'month' THEN
        SET start_date = DATE_FORMAT(NOW(), '%Y-%m-01');
        SET end_date = LAST_DAY(NOW());
    ELSEIF interval_type = 'day' THEN
        SET start_date = CURDATE() - INTERVAL 1 DAY;
        SET end_date = CURDATE() + INTERVAL 1 DAY;
    ELSEIF interval_type = 'week' THEN
        SET start_date = CURDATE() - INTERVAL WEEKDAY(CURDATE()) DAY;
        SET end_date = CURDATE() + INTERVAL 6 - WEEKDAY(CURDATE()) DAY;
    ELSEIF interval_type = 'year' THEN
        SET start_date = CONCAT(YEAR(NOW()), '-01-01');
        SET end_date = CONCAT(YEAR(NOW()), '-12-31');
    ELSEIF interval_type = 'all' THEN
        SET start_date = '1970-01-01'; -- or another appropriate start date
        SET end_date = NOW() + INTERVAL 1 DAY;
    END IF;

    SELECT p.nama_produk AS 'Nama Produk',
           SUM(dt.jml_beli) AS 'Total Penjualan',
           SUM(dt.hrg_satuan * dt.jml_beli) AS 'Harga'
    FROM produk p
    LEFT JOIN detail_transaksi dt ON p.ID_PRODUK = dt.ID_PRODUK
    LEFT JOIN transaksi t ON dt.id_transaksi = t.id_transaksi
    WHERE t.tgl_transaksi BETWEEN start_date AND end_date
    GROUP BY p.NAMA_PRODUK;
END //
DELIMITER ;


-- Example: all data
CALL PLaporanpenjualan('all');

-- Example: data for the current month
CALL PLaporanpenjualan('month');

-- Example: data for the current day
CALL PLaporanpenjualan('day');

-- Example: data for the current week
CALL PLaporanpenjualan('week');

CALL PLaporanpenjualan('year');


DROP PROCEDURE IF EXISTS PLaporanpenjualanGraph;
DELIMITER //

CREATE PROCEDURE PLaporanpenjualanGraph(
    IN interval_type VARCHAR(10),
    IN selectedValue VARCHAR(255),
    IN selectedYear INT
)
BEGIN
    DECLARE start_date DATE;
    DECLARE end_date DATE;

    IF interval_type = 'day' THEN
        SET start_date = STR_TO_DATE(selectedValue, '%d/%m/%Y');
        SET end_date = start_date + INTERVAL 1 DAY;
	ELSEIF interval_type = 'week' THEN
		SET start_date = DATE_SUB(STR_TO_DATE(SUBSTRING_INDEX(selectedValue, ' - ', 1), '%d/%m/%Y'), INTERVAL (DAYOFWEEK(STR_TO_DATE(SUBSTRING_INDEX(selectedValue, ' - ', 1), '%d/%m/%Y')) - 1) DAY);
		SET end_date = DATE_ADD(STR_TO_DATE(SUBSTRING_INDEX(selectedValue, ' - ', -1), '%d/%m/%Y'), INTERVAL (7 - DAYOFWEEK(STR_TO_DATE(SUBSTRING_INDEX(selectedValue, ' - ', -1), '%d/%m/%Y'))) DAY);
    ELSEIF interval_type = 'month' THEN
        SET start_date = STR_TO_DATE(CONCAT('01/', selectedValue), '%d/%m/%Y');
        SET end_date = LAST_DAY(STR_TO_DATE(CONCAT('01/', selectedValue), '%d/%m/%Y'));
    ELSEIF interval_type = 'year' THEN
        SET start_date = STR_TO_DATE(CONCAT('01/01/', selectedValue), '%d/%m/%Y');
        SET end_date = STR_TO_DATE(CONCAT('31/12/', selectedValue), '%d/%m/%Y');
    ELSEIF interval_type = 'all' THEN
        SET start_date = '1970-01-01';
        SET end_date = NOW() + INTERVAL 1 DAY;
    END IF;

    SELECT 
        p.nama_produk AS 'Nama Produk',
        SUM(dt.jml_beli) AS 'Total Penjualan'
    FROM
        produk p
    LEFT JOIN
        detail_transaksi dt ON p.ID_PRODUK = dt.ID_PRODUK
    LEFT JOIN
        transaksi t ON dt.id_transaksi = t.id_transaksi
    WHERE
        t.tgl_transaksi BETWEEN start_date AND end_date
    GROUP BY
        p.nama_produk;
END;
//
DELIMITER ;




-- function perhintungan Fpenjualanperbulan
-- untuk mengetahui tatol pemasukan di bulan. dari semua transaksi yang terjadi dibulan tersebut 
drop function if exists Fpenjualanperbulan;
delimiter //
create function Fpenjualanperbulan(namejus varchar(100))
returns int
deterministic
begin
	declare total int;
	
		select sum(dt.HRG_SATUAN * dt.JML_BELI)*30 into total
		from detail_transaksi dt
		join produk p
		on dt.ID_PRODUK = p.ID_PRODUK 
		and p.NAMA_PRODUK = upper(namejus)
		;
return total;
end //
delimiter ;

select Fpenjualanperbulan('Maroon Goddess');

-- function perhintungan Fpenjualanpertahun
-- untuk mengatahu total pemasukan pertahun dari semua transaksi di tahun tersebut
drop function if exists Fpenjualanpertahun;
delimiter //
create function Fpenjualanpertahun(namejus varchar(100))
returns int
deterministic
begin
	declare total int;
	
		select sum(dt.HRG_SATUAN * dt.JML_BELI * 30)*12 into total
		from detail_transaksi dt
		join produk p
		on dt.ID_PRODUK = p.ID_PRODUK 
		and p.NAMA_PRODUK = upper(namejus)
		;
return total;
end //
delimiter ;

select Fpenjualanpertahun('Maroon Goddess');

-- Function auto autogenerate fgenidproduk
-- untuk autogenerate id produk 
drop function if exists fgenidproduk;
delimiter //
create function fgenidproduk()
returns varchar (5)
deterministic
begin
	declare hasil varchar(5);
	 select concat('P',
                lpad(ifnull(convert(substr(max(id_produk),2,4),unsigned),0)+1,
                     4,'0')
			   ) into hasil
	from produk;
    return hasil;
end //
delimiter ;
select fgenidproduk();


-- Function  fgunidtrans
DELIMITER $$
DROP FUNCTION IF EXISTS fgenidtrans;
CREATE DEFINER=`root`@`localhost` FUNCTION `fgenidtrans`() 
RETURNS varchar(12) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
    DECLARE tanggal VARCHAR(8);
    DECLARE counter INT;
    DECLARE adatidak INT;
    DECLARE hasil VARCHAR(12);

    SELECT DATE_FORMAT(CURDATE(), '%y%m%d') INTO tanggal;

    -- Set tanggal = '05072021';
    -- Uncomment the line above if you want to use a specific date for testing

    SELECT CAST(RIGHT(MAX(id_transaksi), 3) AS UNSIGNED) INTO adatidak
    FROM transaksi
    WHERE SUBSTRING(id_transaksi, 2, 6) = tanggal;

    IF adatidak is not null THEN
        SELECT CAST(RIGHT(MAX(id_transaksi), 3) AS UNSIGNED) INTO counter
        FROM transaksi
        WHERE SUBSTRING(id_transaksi, 2, 6) = tanggal;

        SET counter = counter + 1;
        SET hasil = CONCAT('T', tanggal, LPAD(counter, 3, '0'));
    ELSE
        SET hasil = CONCAT('T', tanggal, '001');
    END IF;

    RETURN hasil;
END $$
delimiter ;

select fgenidtrans();

SET @hasil := (SELECT fgenidtrans());
-- prosedur menampilakan phistorypembelian

-- prosedur menampilkan pdetailhistori



-- proseder menapilakna psearchproduk
-- untuk menfilter produk
drop procedure if exists psearchproduk;
delimiter //
create procedure psearchproduk (in nameproduk varchar(100))
begin
	select *
		from produk 
	where NAMA_PRODUK like concat( '%',nameproduk, '%')
;
end //
delimiter ;

call psearchproduk('fr');

-- view sort by category
drop view if exists vSortCat;
create view vSortCat as 
select * from produk 
order by id_kategori asc;
select * from vSortCat;

-- view sort by harga
drop view if exists vSortHarga;
create view vSortHarga as
select * from produk
order by harga_jual;
select * from vSortHarga;