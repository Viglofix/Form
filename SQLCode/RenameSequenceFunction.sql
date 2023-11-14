CREATE OR REPLACE FUNCTION RenameSequence(seq_name VARCHAR(256), new_seq_name VARCHAR(50)) 
RETURNS VOID AS $$ 
DECLARE
seq_name_var VARCHAR(256) := seq_name;
new_seq_var VARCHAR(256) := new_seq_name;
BEGIN
IF EXISTS(SELECT 1 FROM pg_sequences WHERE sequencename = seq_name_var) THEN
ALTER SEQUENCE seq_name_var RENAME TO new_seq_var; 
END IF;
END $$ LANGUAGE plpgsql;