INSERT INTO clickup_required_data (
    id,
    full_name,
    email,
    phone_number,
    date_of_birth,
    github_account,
    name_of_university_or_occupation,
    programming_languages,
    graphic_inspiration,
    proficient_graphic_tools,
    experience,
    finished_project,
    english_level,
    learning_goals,
    goal_of_academy_participation,
    practices_start,
    practices_end,
    additional_information,
    column_id,
    range,
    note,
    assigned_to_project_id,
    specialization_id
) VALUES (
    1,
    'Andrzej Nowicki',
    'andrzej.nowicki@example.com',
    '123-456-789',
    '1990-05-15',
    'andrzejonowicki',
    'Uniwersytet Informatyczny',
    'JavaScript, HTML, CSS',
    'Sztuka cyfrowa, projektowanie UI/UX',
    'Adobe Photoshop, Sketch',
    '5 lat doświadczenia w programowaniu frontend',
    'Strona internetowa e-commerce dla firmy XYZ',
    'b2',
    'Badanie machine learning w web development',
    'Rozwój umiejętności i pozostawanie na bieżąco z najnowszymi technologiami',
    '2023-02-01',
    '2023-05-01',
    'Pasjonat projektów open source i aktywny uczestnik społeczności programistycznej.',
    '4',
    3,
    'Tekst notatki',
    NULL, -- or provide a default value for assigned_to_project_id
    (SELECT id FROM specializations WHERE domain = 'Frontend' AND role = 'react')
  ),
 (
    2,
    'Anna Kowalska',
    'anna.kowalska@example.com',
    '987-654-321',
    '1995-08-23',
    'annakowalska_dev',
    'Politechnika Warszawska',
    'JavaScript, Python',
    'Wizualizacja danych, minimalistyczny design',
    'Matplotlib, Tableau',
    '3 lata doświadczenia w programowaniu backend',
    'API do aplikacji do czasu rzeczywistego',
    'b2',
    'Badanie architektury mikrousług',
    'Poszerzenie wiedzy i współpraca z profesjonalistami branżowymi',
    '2023-03-15',
    '2023-06-15',
    'Z entuzjazmem podchodzę do udziału w projektach open source i tworzenia skalowalnych systemów.',
    '3',
    2,
    'Dodatkowy tekst notatki',
    NULL,
    (SELECT id FROM specializations WHERE domain = 'Backend' AND role = 'node.js')
),
(
    3,
    'Piotr Nowak',
    'piotr.nowak@example.com',
    '555-123-456',
    '1988-12-10',
    'piotrnowak_dev',
    'Uniwersytet Śląski',
    'JavaScript, Next.js',
    'Nowoczesny design interfejsu, interaktywne aplikacje internetowe',
    'Figma, Adobe XD',
    '7 lat doświadczenia w programowaniu fullstack',
    'System rezerwacji online dla biura podróży',
    'b2',
    'Opanowanie GraphQL i architektury serverless',
    'Nawiązanie kontaktów i śledzenie trendów branżowych',
    '2023-04-01',
    '2023-07-01',
    'Aktywny uczestnik projektów open source i orędownik praktyk czystego kodu.',
    '2',
    3,
    'Dodatkowe uwagi na temat projektu',
    NULL,
    (SELECT id FROM specializations WHERE domain = 'Frontend' AND role = 'react')
),
(
    4,
    'Anna Kowalska',
    'anna.kowalska@example.com',
    '987-654-321',
    '1995-08-22',
    'annakowalska-dev',
    'Instytut Technologiczny',
    'JavaScript, Python, SQL',
    'Sztuka cyfrowa, Projektowanie UX',
    'Adobe Illustrator, Figma',
    '4 lata doświadczenia w programowaniu backend',
    'API na poziomie przedsiębiorstwa dla XYZ Corporation',
    'c1',
    'Badanie technologii blockchain w programowaniu',
    'Rozwijanie umiejętności i być na bieżąco z nowymi technologiami',
    '2023-03-15',
    '2023-06-15',
    'Aktywny współpracownik w projektach open source i zapalony uczeń w społeczności technicznej.',
    '3',
    3,
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
    NULL,
    (SELECT id FROM specializations WHERE domain = 'Backend' AND role = 'node.js')
),
(
    5,
    'Jan Wiśniewski',
    'jan.wisniewski@example.com',
    '555-123-789',
    '1988-11-10',
    'janwisniewski-dev',
    'Akademia Programistyczna',
    'JavaScript, Java, HTML, CSS',
    'Grafika komputerowa, Projektowanie interfejsów',
    'Adobe XD, Canva',
    '6 lat doświadczenia w programowaniu fullstack',
    'Aplikacja e-commerce zintegrowana z płatnościami online',
    'b1',
    'Pogłębianie wiedzy z zakresu sztucznej inteligencji w aplikacjach webowych',
    'Rozwój umiejętności i zdobycie wiedzy na temat nowoczesnych rozwiązań webowych',
    '2023-04-01',
    '2023-07-01',
    'Entuzjasta otwartego oprogramowania i aktywny uczestnik lokalnych meet-upów programistycznych.',
    '1',
    2,
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, turpis vel ultricies feugiat, nibh elit dignissim quam, ac lacinia tellus nulla sit amet arcu.',
    NULL,
    (SELECT id FROM specializations WHERE domain = 'Backend' AND role = '.net')
),
(
    6,
    'Karolina Majewska',
    'karolina.majewska@example.com',
    '111-222-333',
    '1993-06-25',
    'karolinam-dev',
    'Politechnika Programistyczna',
    'Dart, Java, Kotlin',
    'Ilustracje cyfrowe, Design interfejsów mobilnych',
    'Figma, Adobe Illustrator',
    '3 lata doświadczenia w programowaniu mobilnym',
    'Aplikacja mobilna dla sektora edukacyjnego',
    'b2',
    'Eksploracja rozwiązań związanych z sztuczną inteligencją w aplikacjach mobilnych',
    'Rozwój umiejętności w obszarze programowania mobilnego i śledzenie nowości technologicznych',
    '2023-05-01',
    '2023-08-01',
    'Aktywna uczestniczka hackathonów i pasjonatka tworzenia innowacyjnych rozwiązań mobilnych.',
    '3',
    3,
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin aliquam, quam vel lacinia scelerisque, justo turpis bibendum arcu, non tempus dolor urna vel lectus.',
    NULL,
    (SELECT id FROM specializations WHERE domain = 'Frontend' AND role = 'react native')
),
(
    7,
    'Michał Nowak',
    'michal.nowak@example.com',
    '555-111-222',
    '1991-09-18',
    'michalnowak-dev',
    'Akademia Informatyczna',
    'JavaScript, Python, SQL',
    'Grafika komputerowa, Projektowanie interfejsów',
    'Adobe XD, Sketch',
    '5 lat doświadczenia w programowaniu backend',
    'System zarządzania zamówieniami dla firmy XYZ',
    'c1',
    'Pogłębianie wiedzy z zakresu mikroserwisów i architektury systemów',
    'Rozwój umiejętności i uczestnictwo w projektach związanych z backendem',
    '2023-06-01',
    '2023-09-01',
    'Aktywny członek społeczności programistycznej i entuzjasta otwartego oprogramowania.',
    '4',
    3,
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, turpis vel ultricies feugiat, nibh elit dignissim quam, ac lacinia tellus nulla sit amet arcu.',
    NULL,
    (SELECT id FROM specializations WHERE domain = 'Backend' AND role = 'node.js')
),
(
    8,
    'Katarzyna Kowalczyk',
    'katarzyna.kowalczyk@example.com',
    '777-333-111',
    '1985-03-10',
    'kasiakowalczyk-design',
    'Akademia Sztuk Pięknych',
    'Brak',
    'Sztuka współczesna, Design graficzny',
    'Adobe Illustrator, Photoshop',
    '8 lat doświadczenia w projektowaniu graficznym',
    'Identyczność wizualna dla firmy ABC',
    'b1',
    'Rozwinięcie umiejętności w projektowaniu interaktywnych mediów',
    'Pozyskanie wiedzy z obszaru designu interaktywnego i nowoczesnych trendów',
    '2023-07-01',
    '2023-10-01',
    'Uczestniczka wielu wystaw sztuki i zdobywczyni nagrody w konkursie projektowania graficznego.',
    '3',
    1,
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus fermentum elit quis justo semper, nec mattis lectus fermentum.',
    NULL,
    (SELECT id FROM specializations WHERE domain = 'Others' AND role = 'grafika')
),
(
    9,
    'Michał Lewandowski',
    'michal.lewandowski@example.com',
    '555-444-333',
    '1987-09-05',
    'michallewandowski-art',
    'Akademia Sztuk Pięknych',
    '',
    'Sztuka współczesna, Design graficzny',
    'Adobe Illustrator, InDesign',
    '6 lat doświadczenia w projektowaniu graficznym',
    'Projekt katalogu artystycznego dla galerii sztuki',
    'a2',
    'Doskonalenie umiejętności w projektowaniu multimedialnych treści artystycznych',
    'Zdobycie nowych umiejętności w obszarze designu interaktywnego',
    '2023-08-01',
    '2023-11-01',
    'Uczestnik licznych wystaw sztuki oraz współtwórca artystycznych projektów społecznościowych.',
    '3',
    2,
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur vehicula, augue in fermentum cursus, felis est euismod metus, at convallis sapien velit quis ante.',
    NULL,
    (SELECT id FROM specializations WHERE domain = 'Others' AND role = 'grafika')
),
(
    20,
    'Magdalena Nowakowska',
    'magdalena.nowakowska@example.com',
    '555-888-444',
    '1986-07-20',
    'magdalenanowakowska-dev',
    'Politechnika Informatyczna',
    '.Net, C#, SQL',
    'Brak',
    'Brak',
    '9 lat doświadczenia w programowaniu backend',
    'System zarządzania zamówieniami dla firmy ABC',
    'b2',
    'Eksploracja nowoczesnych rozwiązań w programowaniu .Net',
    'Rozwój umiejętności w obszarze backendu i uczestnictwo w projekcie .Net',
    '2023-10-01',
    '2024-01-01',
    'Członek grupy użytkowników .Net oraz prelegent na konferencjach programistycznych.',
    '4',
    3,
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus eu magna ut nulla commodo laoreet eget nec metus.',
    '1',
    (SELECT id FROM specializations WHERE domain = 'Backend' AND role = '.net')
);