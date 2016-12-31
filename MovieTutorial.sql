﻿CREATE TABLE MV_MOVIE
(
	MOVIE_ID INTEGER NOT NULL PRIMARY KEY,
	TITLE VARCHAR(200) NOT NULL,
	DESCRIPTION VARCHAR(1000),
	STORYLINE BLOB SUB_TYPE TEXT,
	RELEASE_YEAR INTEGER,
	RELEASE_DATE TIMESTAMP,
	RUNTIME INTEGER
);

CREATE GENERATOR MV_MOVIE_GEN;

commit transaction;

SET TERM ^ ;

CREATE TRIGGER MV_MOVIE_TRG FOR MV_MOVIE
ACTIVE BEFORE INSERT POSITION 0
AS
BEGIN
    IF (NEW.MOVIE_ID IS NULL) THEN
        NEW.MOVIE_ID = GEN_ID(MV_MOVIE_GEN, 1);
END^


set term ; ^

COMMIT TRANSACTION;
