/* INSERT INTO status_of_recruiter(name_of_the_university,start_date_of_practice,end_date_of_practice,type_of_practice_id)
VALUES('ZST Jaslo','2019-01-01','2019-01-01',2); */


SELECT * FROM clickup_required_data
INNER JOIN status_of_recruiter ON status_of_recruiter.id_status_of_recruiter = clickup_required_data.status_id
INNER JOIN type_of_practice ON type_of_practice.id_type_of_practice = status_of_recruiter.type_of_practice_id
INNER JOIN english_level ON english_level.id_english_level = clickup_required_data.english_level_id;