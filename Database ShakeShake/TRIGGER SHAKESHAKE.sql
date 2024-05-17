-- ceritanya jika ada produksi
insert into produksi (id_produk, tgl_buat, tgl_kadaluwarsa, harga_modal, jumlah_produksi) values
('P0001',now()-1, now()+7, 20000, 7);
insert into produksi (id_produk, tgl_buat, tgl_kadaluwarsa, harga_modal, jumlah_produksi) values
('P0002',now(), now()+7, 10000, 15);

drop trigger if exists tInsProduksi;
delimiter //
create trigger tInsProduksi
before insert on produksi
for each row
begin
	declare hrg_jual int;
    
    select HARGA_JUAL into hrg_jual
    from produk
    where ID_PRODUK = new.id_produk;
    
	set new.laba_satuan = hrg_jual - new.harga_modal;
    set new.jumlah_terjual = 0;
    set new.jumlah_rusak = 0;
    set new.jumlah_sisa = new.jumlah_produksi;
    
    update produk
    set STOK_TOTAL = STOK_TOTAL + new.jumlah_produksi
    where ID_PRODUK = new.id_produk;
end //
delimiter ;

select * from produksi;

-- ceritanya jika ada penjualan
insert into transaksi (id_transaksi,nama_pelanggan, jml_item, total) values 
('T231130001','INDRA',2,75000);
insert into detail_transaksi (id_transaksi,id_produk,jml_beli,hrg_satuan) values
('T231130001','P0001',2,25000);
insert into detail_transaksi (id_transaksi,id_produk,jml_beli,hrg_satuan) values
('T231130001','P0002',1,25000);


SET @hasil := (SELECT fgenidtrans());
-- select @hasil;
INSERT INTO transaksi (id_transaksi, nama_pelanggan, jml_item, total) VALUES 
(@hasil, 'Rini', '2', '40000');
insert into detail_transaksi (id_transaksi, id_produk, jml_beli, hrg_satuan) values
( @hasil, 'P0002', '1', '25000');
insert into detail_transaksi 
 values ( @hasil, 'P0001', 1, 15000);

insert into transaksi (id_transaksi,nama_pelanggan, jml_item, total) values 
('T231130002','VALEN',1,250000);
insert into detail_transaksi (id_transaksi,id_produk,jml_beli,hrg_satuan) values
('T231130002','P0001',10,25000);

insert into transaksi (id_transaksi,nama_pelanggan, jml_item, total) values 
('T231202001', null ,1,50000);
insert into detail_transaksi (id_transaksi,id_produk,jml_beli,hrg_satuan) values
('T231202001','P0002',2,25000);

drop trigger if exists tInsDetailTransaksi;
delimiter //
create trigger tInsDetailTransaksi
before insert on detail_transaksi
for each row
begin
    declare id_prod int;
    declare jm_sisa int;
    declare jm_beli int;
    declare selisih int;
    declare lb_sat int;
    declare hit_laba int;
    declare nm_produk varchar(255);
    
    set jm_beli = new.jml_beli;
    
	update produk
    set STOK_TOTAL = STOK_TOTAL - new.jml_beli
    where ID_PRODUK = new.id_produk;
    
	SELECT nama_produk INTO nm_produk
    FROM produk
    WHERE ID_PRODUK = NEW.id_produk;

    set hit_laba = 0;
    while jm_beli > 0 do
		select id_produksi, laba_satuan, JUMLAH_SISA into id_prod, lb_sat, jm_sisa 
		from produksi
		where id_produk = new.id_produk and jumlah_sisa <> 0
		order by id_produksi asc
		limit 1;
        
        if jm_beli <= jm_sisa then
			update produksi
            set jumlah_terjual = jumlah_terjual + jm_beli, 
                jumlah_sisa = jumlah_sisa - jm_beli
            where id_produksi = id_prod;
            set hit_laba = hit_laba + (lb_sat * jm_beli);
            set jm_beli = 0;
		else          
			set selisih = jm_beli - jm_sisa;
			update produksi         
            set jumlah_terjual = jumlah_terjual + jm_sisa, 
                jumlah_sisa = jumlah_sisa - jm_sisa
            where id_produksi = id_prod;
            set hit_laba = hit_laba + (lb_sat * jm_sisa);
            set jm_beli = selisih;
        end if;
    end while;
    
    insert into log_laba_rugi(keterangan,id_transaksi,laba) values 
		((CONCAT('Penjualan Produk ',nm_produk)), new.id_transaksi,hit_laba);
end //
delimiter ;

-- ceritanya barang expired
insert into barang_expired(tgl_buang,id_produksi,keterangan,jumlah_buang) values
('2023-11-30',7,'Segel Lepas',2);

drop trigger if exists tInBarangExpired;
delimiter //
create trigger tInBarangExpired
after insert on barang_expired
for each row
begin
    declare jm_buang int;
    declare hit_rugi int;
    declare id_prod int;
    declare hrg_modal int;
    declare jml_sisa int;
    declare id_produks varchar(255);
    
    set jm_buang = new.jumlah_buang;
    set id_prod = new.id_produksi;

    set hit_rugi = 0;
    select id_produksi, harga_modal, jumlah_sisa, ID_PRODUK into 
        id_prod, hrg_modal, jml_sisa, id_produks
    from produksi
    where id_produksi = id_prod and jumlah_sisa >= jm_buang;

    update produk
    set STOK_TOTAL = STOK_TOTAL - new.jumlah_buang
    where ID_PRODUK = id_produks;
    
    update produksi
    set jumlah_rusak = jumlah_rusak + jm_buang,
        jumlah_sisa = jumlah_sisa - jm_buang
    where id_produksi = id_prod;

    set hit_rugi = hrg_modal * jm_buang;

    insert into log_laba_rugi(keterangan, id_exp, rugi) values
        (new.keterangan, new.id_exp, hit_rugi);
end //
delimiter ;

select * from produksi;


insert into produk (id_kategori,nama_produk, deskripsi,harga_jual) values 
('K002','Lime Breeze','Nonanoa',25000);


drop trigger if exists tNewProduk;
delimiter //
create trigger tnewproduk
before insert on produk
for each row
begin
	set new.id_produk = fgenidproduk();
    set new.stok_total = 0;
end //
delimiter ;
