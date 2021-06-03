CREATE TABLE Договор (
    ID                INTEGER PRIMARY KEY ASC AUTOINCREMENT,
    IDФирмыПодрядчика INTEGER REFERENCES ФирмаПодрядчик (ID),
    IDЖилогоПомещения INTEGER REFERENCES ЖилоеПомещение (ID),
    КраткоеОписание   TEXT
);