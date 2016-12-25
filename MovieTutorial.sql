﻿CREATE TABLE MOVIE
(
	MOVIE_ID INTEGER NOT NULL PRIMARY KEY,
	TITLE VARCHAR(200) NOT NULL,
	DESCRIPTION VARCHAR(1000),
	STORYLINE BLOB SUB_TYPE TEXT,
	RELEASE_YEAR INTEGER,
	RELEASE_DATE TIMESTAMP,
	RUNTIME INTEGER
);

CREATE GENERATOR MOVIE_GEN;

commit transaction;

SET TERM ^ ;

CREATE TRIGGER MOVIE_GEN_TRG FOR MOVIE
ACTIVE BEFORE INSERT POSITION 0
AS
BEGIN
    IF (NEW.MOVIE_ID IS NULL) THEN
        NEW.MOVIE_ID = GEN_ID(MOVIE_GEN, 1);
END^


set term ; ^

COMMIT TRANSACTION;
