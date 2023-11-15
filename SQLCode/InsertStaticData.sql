/* w większości systemów zarządzania bazą danych, pojedyncze cudzysłowy są używane do oznaczania ciągów znaków, podwójne cudzysłowy są używane do oznaczania nazw kolumn lub tabel. */

INSERT INTO english_level(english_level_property)
VALUES('B1'),
('B2'),
('C1'),
('C2')

INSERT INTO type_of_practice(id_type_of_practice_name)
VALUES('Szkola'),
('Studia'),
('Praca');

INSERT INTO specializations(specialization_name) 
VALUES
('BE (.net)'),
('BE (node.js)'),
('FE (React/Next.js)'),
('Mobile (React Native)'),
('UI/UX'),
('Grafika'),
('Social Media / Marketing'),
('PM'),
('Copywriting');

/* \i B:/PraktykiAPI/Form/SQLCode/InsertStaticData.sql; */