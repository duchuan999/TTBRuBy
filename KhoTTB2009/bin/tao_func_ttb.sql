CREATE OR REPLACE FUNCTION medibv.upd_tscdkhoa(d_id "numeric", d_makp "numeric", d_makho "numeric", d_manguon "numeric", d_nhomcc "numeric", d_stt "numeric", d_mabd "numeric", d_losx "varchar", d_sothe "varchar", d_tyle "numeric", d_sotien "numeric", d_namsx "varchar", d_namsd "varchar")
  RETURNS void AS
$BODY$ 
begin
	update medibv.d_tscdkhoa set makp=d_makp,makho=d_makho,manguon=d_manguon,nhomcc=d_nhomcc,stt=d_stt,mabd=d_mabd,losx=d_losx,sothe=d_sothe,tyle=d_tyle,sotien=d_sotien,namsx=d_namsx,namsd=d_namsd where id=d_id;
	if found=false then
		insert into medibv.d_tscdkhoa(id,makp,makho,manguon,nhomcc,stt,mabd,losx,sothe,tyle,sotien,namsx,namsd) values (d_id,d_makp,d_makho,d_manguon,d_nhomcc,d_stt,d_mabd,d_losx,d_sothe,d_tyle,d_sotien,d_namsx,d_namsd);
	end if;
end;
 $BODY$
  LANGUAGE 'plpgsql' VOLATILE;