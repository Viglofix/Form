/* SELECT string_agg(column_name, ', ')
FROM information_schema.columns
WHERE table_name = 'drop_files'
AND column_name != 'file_data'; */