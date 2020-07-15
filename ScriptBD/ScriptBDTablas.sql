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