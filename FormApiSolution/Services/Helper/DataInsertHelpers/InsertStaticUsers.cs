using DataBase.Model;

namespace Services.Helper.DataInsertHelpers;

public class InsertStaticUsers {
    public List<ClickUpRequiredDataModel> GetAllStaticUsers() {
         var clickUpDataList = new List<ClickUpRequiredDataModel>
          {
    new ClickUpRequiredDataModel
    {
        Id = 1,
        FullName = "Andrzej Nowicki",
        Email = "andrzej.nowicki@example.com",
        PhoneNumber = "123-456-789",
        DateOfBirth = new DateTime(1990, 05, 15),
        GithubAccount = "andrzejonowicki",
        NameOfUniversityOrOccupation = "ZST Jasło",
        ProgrammingLangugages = "JavaScript, HTML, CSS",
        GraphicInspiration = "Sztuka cyfrowa, projektowanie UI/UX",
        ProficientGraphicTools = "Adobe Photoshop, Sketch",
        Experience = "5 lat doświadczenia w programowaniu frontend",
        FinishedProject = "Strona internetowa e-commerce dla firmy XYZ",
        English_Level = "b2",
        LearningGoals = "Badanie machine learning w web development",
        GoalOfAcademyParticipation = "Rozwój umiejętności i pozostawanie na bieżąco z najnowszymi technologiami",
        PracticesStart = new DateTime(2023, 02, 01),
        PracticesEnd = new DateTime(2023, 05, 01),
        AdditionalInformation = "Pasjonat projektów open source i aktywny uczestnik społeczności programistycznej.",
        ColumnId = "4",
        Range = 3,
        Note = "Tekst notatki",
        AssignedToProjectId = null,
        Specialization_Id = 3
    },
    new ClickUpRequiredDataModel
    {
        Id = 2,
        FullName = "Anna Kowalska",
        Email = "anna.kowalska@example.com",
        PhoneNumber = "987-654-321",
        DateOfBirth = new DateTime(1995, 08, 23),
        GithubAccount = "annakowalska_dev",
        NameOfUniversityOrOccupation = "ZST Jasło",
        ProgrammingLangugages = "JavaScript, Python",
        GraphicInspiration = "Wizualizacja danych, minimalistyczny design",
        ProficientGraphicTools = "Matplotlib, Tableau",
        Experience = "3 lata doświadczenia w programowaniu backend",
        FinishedProject = "API do aplikacji do czasu rzeczywistego",
        English_Level = "b2",
        LearningGoals = "Badanie architektury mikrousług",
        GoalOfAcademyParticipation = "Poszerzenie wiedzy i współpraca z profesjonalistami branżowymi",
        PracticesStart = new DateTime(2023, 03, 15),
        PracticesEnd = new DateTime(2023, 06, 15),
        AdditionalInformation = "Z entuzjazmem podchodzę do udziału w projektach open source i tworzenia skalowalnych systemów.",
        ColumnId = "3",
        Range = 2,
        Note = "Dodatkowy tekst notatki",
        AssignedToProjectId = null,
        Specialization_Id = 2
    },
    new ClickUpRequiredDataModel
    {
        Id = 3,
        FullName = "Piotr Nowak",
        Email = "piotr.nowak@example.com",
        PhoneNumber = "555-123-456",
        DateOfBirth = new DateTime(1988, 12, 10),   
        GithubAccount = "piotrnowak_dev",
        NameOfUniversityOrOccupation = "ZST Rzeszów",
        ProgrammingLangugages = "JavaScript, Next.js",
        GraphicInspiration = "Nowoczesny design interfejsu, interaktywne aplikacje internetowe",
        ProficientGraphicTools = "Figma, Adobe XD",
        Experience = "7 lat doświadczenia w programowaniu fullstack",
        FinishedProject = "System rezerwacji online dla biura podróży",
        English_Level = "b2",
        LearningGoals = "Opanowanie GraphQL i architektury serverless",
        GoalOfAcademyParticipation = "Nawiązanie kontaktów i śledzenie trendów branżowych",
        PracticesStart = new DateTime(2023, 04, 01),
        PracticesEnd = new DateTime(2023, 07, 01),
        AdditionalInformation = "Aktywny uczestnik projektów open source i orędownik praktyk czystego kodu.",
        ColumnId = "2",
        Range = 3,
        Note = "Dodatkowe uwagi na temat projektu",
        AssignedToProjectId = null,
        Specialization_Id = 3
    },
    new ClickUpRequiredDataModel
    {
        Id = 4,
        FullName = "Anna Kowalska",
        Email = "anna.kowalska@example.com",
        PhoneNumber = "987-654-321",
        DateOfBirth = new DateTime(1995, 08, 22),
        GithubAccount = "annakowalska-dev",
        NameOfUniversityOrOccupation = "Politechnika Rzeszowska",
        ProgrammingLangugages = "JavaScript, Python, SQL",
        GraphicInspiration = "Sztuka cyfrowa, Projektowanie UX",
        ProficientGraphicTools = "Adobe Illustrator, Figma",
        Experience = "4 lata doświadczenia w programowaniu backend",
        FinishedProject = "API na poziomie przedsiębiorstwa dla XYZ Corporation",
        English_Level = "c1",
        LearningGoals = "Badanie technologii blockchain w programowaniu",
        GoalOfAcademyParticipation = "Rozwijanie umiejętności i być na bieżąco z nowymi technologiami",
        PracticesStart = new DateTime(2023, 03, 15),
        PracticesEnd = new DateTime(2023, 06, 15),
        AdditionalInformation = "Aktywny współpracownik w projektach open source i zapalony uczeń w społeczności technicznej.",
        ColumnId = "3",
        Range = 3,
        Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
        AssignedToProjectId = null,
        Specialization_Id = 3
    },
     new ClickUpRequiredDataModel
    {
        Id = 5,
        FullName = "Jan Wiśniewski",
        Email = "jan.wisniewski@example.com",
        PhoneNumber = "555-123-789",
        DateOfBirth = new DateTime(1988, 11, 10),
        GithubAccount = "janwisniewski-dev",
        NameOfUniversityOrOccupation = "Uniwersytet Rzeszowski",
        ProgrammingLangugages = "JavaScript, Java, HTML, CSS",
        GraphicInspiration = "Grafika komputerowa, Projektowanie interfejsów",
        ProficientGraphicTools = "Adobe XD, Canva",
        Experience = "6 lat doświadczenia w programowaniu fullstack",
        FinishedProject = "Aplikacja e-commerce zintegrowana z płatnościami online",
        English_Level = "b1",
        LearningGoals = "Pogłębianie wiedzy z zakresu sztucznej inteligencji w aplikacjach webowych",
        GoalOfAcademyParticipation = "Rozwój umiejętności i zdobycie wiedzy na temat nowoczesnych rozwiązań webowych",
        PracticesStart = new DateTime(2023, 04, 01),
        PracticesEnd = new DateTime(2023, 07, 01),
        AdditionalInformation = "Entuzjasta otwartego oprogramowania i aktywny uczestnik lokalnych meet-upów programistycznych.",
        ColumnId = "1",
        Range = 2,
        Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, turpis vel ultricies feugiat, nibh elit dignissim quam, ac lacinia tellus nulla sit amet arcu.",
        AssignedToProjectId = null,
        Specialization_Id = 2
    },
    new ClickUpRequiredDataModel
    {
        Id = 6,
        FullName = "Karolina Majewska",
        Email = "karolina.majewska@example.com",
        PhoneNumber = "111-222-333",
        DateOfBirth = new DateTime(1993, 06, 25),
        GithubAccount = "karolinam-dev",
        NameOfUniversityOrOccupation = "ZST Leżajsk",
        ProgrammingLangugages = "Dart, Java, Kotlin",
        GraphicInspiration = "Ilustracje cyfrowe, Design interfejsów mobilnych",
        ProficientGraphicTools = "Figma, Adobe Illustrator",
        Experience = "3 lata doświadczenia w programowaniu mobilnym",
        FinishedProject = "Aplikacja mobilna dla sektora edukacyjnego",
        English_Level = "b2",
        LearningGoals = "Eksploracja rozwiązań związanych z sztuczną inteligencją w aplikacjach mobilnych",
        GoalOfAcademyParticipation = "Rozwój umiejętności w obszarze programowania mobilnego i śledzenie nowości technologicznych",
        PracticesStart = new DateTime(2023, 05, 01),
        PracticesEnd = new DateTime(2023, 08, 01),
        AdditionalInformation = "Aktywna uczestniczka hackathonów i pasjonatka tworzenia innowacyjnych rozwiązań mobilnych.",
        ColumnId = "3",
        Range = 3,
        Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin aliquam, quam vel lacinia scelerisque, justo turpis bibendum arcu, non tempus dolor urna vel lectus.",
        AssignedToProjectId = null,
        Specialization_Id = 4
    },
    new ClickUpRequiredDataModel
    {
        Id = 7,
        FullName = "Michał Nowak",
        Email = "michal.nowak@example.com",
        PhoneNumber = "555-111-222",
        DateOfBirth = new DateTime(1991, 09, 18),
        GithubAccount = "michalnowak-dev",
        NameOfUniversityOrOccupation = "Politechnika Rzeszowska",
        ProgrammingLangugages = "JavaScript, Python, SQL",
        GraphicInspiration = "Grafika komputerowa, Projektowanie interfejsów",
        ProficientGraphicTools = "Adobe XD, Sketch",
        Experience = "5 lat doświadczenia w programowaniu backend",
        FinishedProject = "System zarządzania zamówieniami dla firmy XYZ",
        English_Level = "c1",
        LearningGoals = "Pogłębianie wiedzy z zakresu mikroserwisów i architektury systemów",
        GoalOfAcademyParticipation = "Rozwój umiejętności i uczestnictwo w projektach związanych z backendem",
        PracticesStart = new DateTime(2023, 06, 01),
        PracticesEnd = new DateTime(2023, 09, 01),
        AdditionalInformation = "Aktywny członek społeczności programistycznej i entuzjasta otwartego oprogramowania.",
        ColumnId = "4",
        Range = 3,
        Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, turpis vel ultricies feugiat, nibh elit dignissim quam, ac lacinia tellus nulla sit amet arcu.",
        AssignedToProjectId = null,
        Specialization_Id = 3
    },
    new ClickUpRequiredDataModel
{
    Id = 8,
    FullName = "Katarzyna Kowalczyk",
    Email = "katarzyna.kowalczyk@example.com",
    PhoneNumber = "777-333-111",
    DateOfBirth = new DateTime(1985, 03, 10),
    GithubAccount = "kasiakowalczyk-design",
    NameOfUniversityOrOccupation = "Politechnika Rzeszowska",
    ProgrammingLangugages = "Brak",
    GraphicInspiration = "Sztuka współczesna, Design graficzny",
    ProficientGraphicTools = "Adobe Illustrator, Photoshop",
    Experience = "8 lat doświadczenia w projektowaniu graficznym",
    FinishedProject = "Identyczność wizualna dla firmy ABC",
    English_Level = "b1",
    LearningGoals = "Rozwinięcie umiejętności w projektowaniu interaktywnych mediów",
    GoalOfAcademyParticipation = "Pozyskanie wiedzy z obszaru designu interaktywnego i nowoczesnych trendów",
    PracticesStart = new DateTime(2023, 07, 01),
    PracticesEnd = new DateTime(2023, 10, 01),
    AdditionalInformation = "Uczestniczka wielu wystaw sztuki i zdobywczyni nagrody w konkursie projektowania graficznego.",
    ColumnId = "3",
    Range = 1,
    Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus fermentum elit quis justo semper, nec mattis lectus fermentum.",
    AssignedToProjectId = null,
    Specialization_Id = 5
},
 new ClickUpRequiredDataModel
    {
        Id = 9,
        FullName = "Michał Lewandowski",
        Email = "michal.lewandowski@example.com",
        PhoneNumber = "555-444-333",
        DateOfBirth = new DateTime(1987, 09, 05),
        GithubAccount = "michallewandowski-art",
        NameOfUniversityOrOccupation = "Politechnika Rzeszowska",
        ProgrammingLangugages = "",
        GraphicInspiration = "Sztuka współczesna, Design graficzny",
        ProficientGraphicTools = "Adobe Illustrator, InDesign",
        Experience = "6 lat doświadczenia w projektowaniu graficznym",
        FinishedProject = "Projekt katalogu artystycznego dla galerii sztuki",
        English_Level = "a2",
        LearningGoals = "Doskonalenie umiejętności w projektowaniu multimedialnych treści artystycznych",
        GoalOfAcademyParticipation = "Zdobycie nowych umiejętności w obszarze designu interaktywnego",
        PracticesStart = new DateTime(2023, 08, 01),
        PracticesEnd = new DateTime(2023, 11, 01),
        AdditionalInformation = "Uczestnik licznych wystaw sztuki oraz współtwórca artystycznych projektów społecznościowych.",
        ColumnId = "3",
        Range = 2,
        Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur vehicula, augue in fermentum cursus, felis est euismod metus, at convallis sapien velit quis ante.",
        AssignedToProjectId = null,
        Specialization_Id = 3
    },
    new ClickUpRequiredDataModel
    {
        Id = 20,
        FullName = "Magdalena Nowakowska",
        Email = "magdalena.nowakowska@example.com",
        PhoneNumber = "555-888-444",
        DateOfBirth = new DateTime(1986, 07, 20),
        GithubAccount = "magdalenanowakowska-dev",
        NameOfUniversityOrOccupation = "ZST Rzeszów",
        ProgrammingLangugages = ".Net, C#, SQL",
        GraphicInspiration = "Brak",
        ProficientGraphicTools = "Brak",
        Experience = "9 lat doświadczenia w programowaniu backend",
        FinishedProject = "System zarządzania zamówieniami dla firmy ABC",
        English_Level = "b2",
        LearningGoals = "Eksploracja nowoczesnych rozwiązań w programowaniu .Net",
        GoalOfAcademyParticipation = "Rozwój umiejętności w obszarze backendu i uczestnictwo w projekcie .Net",
        PracticesStart = new DateTime(2023, 10, 01),
        PracticesEnd = new DateTime(2024, 01, 01),
        AdditionalInformation = "Członek grupy użytkowników .Net oraz prelegent na konferencjach programistycznych.",
        ColumnId = "1",
        Range = 3,
        Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus eu magna ut nulla commodo laoreet eget nec metus.",
        AssignedToProjectId = null,
        Specialization_Id = 1
    },
};
return clickUpDataList;
    }
}