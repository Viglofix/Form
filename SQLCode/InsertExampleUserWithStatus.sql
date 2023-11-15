INSERT INTO clickup_required_data(full_name,email,phone_number,date_of_birth,specialization_id,status_of_recruiter,status_id,github_account)
VALUES('Janusz Kowalski','example@gmai.com','999888777','2022-01-01',3,'szkola',1,'github432.cdo');

SELECT * FROM clickup_required_data
INNER JOIN status_of_recruiter ON status_of_recruiter.id_status_of_recruiter = clickup_required_data.status_id
INNER JOIN type_of_practice ON type_of_practice.id_type_of_practice = status_of_recruiter.type_of_practice_id
INNER JOIN english_level ON english_level.id_english_level = clickup_required_data.english_level_id;
INNER JOIN specializations ON specializations.id_specialization = clickup_required_data.specialization_id;