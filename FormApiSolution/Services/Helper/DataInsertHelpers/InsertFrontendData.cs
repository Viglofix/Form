using DataBase.Model;

namespace Services.Helper.DataInsertHelpers;
public class InsertFrontendData
{
    public List<Test> GetTests()
    {
        return new List<Test>
        {
            new Test()
            {
                Question = "What does HTML stand for?",
                CorrectAnswer = "Hypertext Markup Language",
                Answers = new List<TestAnswer>
                {
                    new TestAnswer
                    {
                        Answer = "Hypertext Makeup Language"
                    },
                    new TestAnswer
                    {
                        Answer = "Hypertext Markdown Language"
                    },
                    new TestAnswer
                    {
                        Answer = "Hypertext Markdown Language"
                    }
                }
            },
            new Test()
            {
                Question = "Which CSS property is used to change the text color of an element?",
                CorrectAnswer = "color",
                Answers = new List<TestAnswer>
                {
                    new TestAnswer
                    {
                        Answer = "text-color"
                    },
                    new TestAnswer
                    {
                        Answer = "font-color"
                    },
                    new TestAnswer
                    {
                        Answer = "background-color"
                    }
                }
            },
            new Test()
            {
                Question = "What is the purpose of JavaScript?",
                CorrectAnswer = "To make web pages interactive",
                Answers = new List<TestAnswer>
                {
                    new TestAnswer
                    {
                         Answer = "To create stylish designs"
                    },
                    new TestAnswer
                    {
                        Answer = "To define the structure of a webpage"
                    },
                    new TestAnswer
                    {
                        Answer = "To add flavors to coffee"
                    }
                }
            },
            new Test()
            {
                Question = "What is the latest version of ECMAScript (JavaScript) as of 2022?",
                CorrectAnswer = "ES11",
                Answers = new List<TestAnswer>
                {
                    new TestAnswer
                    {
                        Answer = "ES10"
                    },
                    new TestAnswer
                    {
                        Answer = "ES09"
                    },
                    new TestAnswer
                    {
                        Answer = "ES13"
                    }
                }
            },
            new Test()
            {
                Question = "Which of the following CSS selectors targets all <p> elements that are direct children of a <div> element?",
                CorrectAnswer = "div > p",
                Answers = new List<TestAnswer>
                {
                    new TestAnswer
                    {
                        Answer = "div ~ p"
                    },
                    new TestAnswer
                    {
                        Answer = "div + p"
                    },
                    new TestAnswer
                    {
                        Answer = "div p"
                    }
                }
             },
             new Test()
             { 
                Question = "What is the purpose of the async and await keywords in C#?",
                CorrectAnswer = "To define asynchronous methods and wait for their completion.",
                Answers = new List<TestAnswer>
                {
                    new TestAnswer
                    {
                        Answer = "To indicate that a method is static."
                    },
                    new TestAnswer
                    {
                        Answer = "To define a class as abstract."
                    },
                    new TestAnswer
                    {
                        Answer = "To mark a method as deprecated."
                    }
                }
             },
            new Test()
            {
                Question = "What is the primary purpose of the try, catch, and finally blocks in C#?",
                CorrectAnswer = "To handle exceptions in code.",
                Answers = new List<TestAnswer>
                {
                    new TestAnswer
                    {
                        Answer = "To define loop constructs.."
                    },
                    new TestAnswer
                    {
                        Answer = "To declare variables."
                    },
                    new TestAnswer
                    {
                        Answer = "To define conditional statements."
                    }
                }
            },
            new Test()
            {
                Question = "How does Dependency Injection benefit software architecture in .NET applications?",
                CorrectAnswer = "It enhances testability and maintainability.",
                Answers = new List<TestAnswer>
                {
                    new TestAnswer
                    {
                        Answer = "It improves code readability.."
                    },
                    new TestAnswer
                    {
                        Answer = "It reduces code duplication.."
                    },
                    new TestAnswer
                    {
                        Answer = "It eliminates the need for exception handling."
                    }
                }
            },
            new Test()
            {
                Question = "What is the role of the using statement in C# when dealing with IDisposable objects?\r\n",
                CorrectAnswer = " To automatically release resources when they are no longer needed.",
                Answers = new List<TestAnswer>
                {
                    new TestAnswer
                    {
                        Answer = " To include namespaces."
                    },
                    new TestAnswer
                    {
                        Answer = "To define variable types."
                    },
                    new TestAnswer
                    {
                        Answer = "To create instances of classes."
                    }
                }
            },


        };
    }
}
