SELECT * FROM clickup_required_data
INNER JOIN specializations ON specializations.id = clickup_required_data.specialization_id;