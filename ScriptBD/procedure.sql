drop PROCEDURE if exists p_Horarios;
Create PROCEDURE p_Horarios(
in _IDKARDEX int,
in _FECHA varchar(50),
in _HORAENTRADAK varchar(50),
in _HORASALIDAK varchar(50),
in _ASITENTRADA varchar(50),
in _ASISTSALIDA varchar(50),
in _FKRFC varchar(50),
in p_opcion int
)
begin

declare existe int;

select count(*) FROM kardex where FKRFC and FECHA into existe;

if existe = 0 then

if  p_opcion = 1 then
insert into kardex values(_IDKARDEX ,_FECHA ,_HORAENTRADAK 
,_HORASALIDAK ,_ASITENTRADA ,_ASISTSALIDA ,_FKRFC);
end if;
end if;
if p_opcion = 2 then
Update kardex set FECHA = _FECHA,HORAENTRADAK = _HORAENTRADAK , HORASALIDAK = _HORASALIDAK,ASITENTRADA = _ASITENTRADA,
ASISTSALIDA = _ASISTSALIDA    where FKRFC = _FKRFC and FECHA = _FECHA ;
  end if;
   if p_opcion = 4 then

 select
* 
from kardex;
end if;
end;

Call p_Horarios(null,'','','','','','',4);
Call p_Horarios(null,'01/08/2020','01:53','01:58','A','F','abcd',2);

select * from horarios,checadas where checadas.hora < horarios.HoraEntrada and horarios.FKRFC = 'abcd' and checadas.FKRFC = 'abcd'