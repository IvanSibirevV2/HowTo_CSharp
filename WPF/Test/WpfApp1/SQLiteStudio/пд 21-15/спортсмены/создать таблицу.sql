CREATE TABLE спортсмены (
    ФИО             TEXT    UNIQUE
                            NOT NULL,
    [*id]           INTEGER UNIQUE
                            NOT NULL
                            PRIMARY KEY AUTOINCREMENT,

    idклассификации INTEGER UNIQUE
                            NOT NULL
                            REFERENCES классификация (id) 
);
