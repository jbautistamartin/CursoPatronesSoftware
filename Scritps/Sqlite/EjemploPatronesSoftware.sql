BEGIN TRANSACTION;
CREATE TABLE `empleado` (
	`id`	INTEGER NOT NULL,
	`nombre`	TEXT NOT NULL,
	PRIMARY KEY(`id`)
);
INSERT INTO `empleado` (id,nombre) VALUES (1,'Empleado UNO desde SQLite');
INSERT INTO `empleado` (id,nombre) VALUES (2,'Empleado DOS desde SQLite');
INSERT INTO `empleado` (id,nombre) VALUES (3,'Empleado TRES desde SQLite');
COMMIT;
