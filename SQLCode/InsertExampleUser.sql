INSERT INTO clickup_required_data(full_name,email,phone_number,date_of_birth,specialization_id)
VALUES('Janusz Kowalski','example@gmai.com','999888777','2022-01-01',3);

/*
 \x
 SELECT * FROM clickup_required_data
 INNER JOIN specializations ON specializations.id_specialization = clickup_required_data.specialization_id;
 */