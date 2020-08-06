create DATABASE Checador;

use checador;

create TABLE TipoPersonal(
IDTIPOPERSONAL INT AUTO_INCREMENT PRIMARY KEY not null,
TIPOPERSONAL Varchar(50)
);

create TABLE Personal(
RFC Varchar(50)  PRIMARY KEY not null,
NOMBRE  Varchar(50), 
APELLIDOP Varchar(50), 
APELLIDOM Varchar(50),
FECHADENACIMIENTO  Varchar(50),
FKTIPOPERSONAL int,
foreign key (FKTIPOPERSONAL) REFERENCES TipoPersonal(IDTIPOPERSONAL)
);

create TABLE Checadas(
IDCHECADO INT AUTO_INCREMENT PRIMARY KEY not null, 
Hora Varchar(50),
FECHA Varchar(50),
FKRFC Varchar(50),
foreign key (FKRFC) REFERENCES Personal(RFC)
);

create TABLE Horarios(
IDhorario INT AUTO_INCREMENT PRIMARY KEY not null, 
Dia Varchar(50),
HoraEntrada Varchar(50),
HoraSalida Varchar(50),
FKRFC Varchar(50),
foreign key (FKRFC) REFERENCES Personal(RFC)
);

create TABLE Kardex(
IDKARDEX INT AUTO_INCREMENT PRIMARY KEY not null, 
FECHA Varchar(50),
HORAENTRADAK Varchar(50),
HORASALIDAK Varchar(50),
ASITENTRADA Varchar(50),
ASISTSALIDA Varchar(50),
FKRFC Varchar(50),
foreign key (FKRFC) REFERENCES Personal(RFC)
);



