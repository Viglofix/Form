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
            new Test()
            {
                Question = " In .NET programming, what is the primary purpose of the Common Language Runtime (CLR)?",
                CorrectAnswer = "To manage memory and system resources, ensuring proper execution of .NET applications.",
                Answers = new List<TestAnswer>(){
                    new TestAnswer(){
                        Answer = "To provide a common language for all programming languages in the .NET framework."
                    },
                    new TestAnswer(){
                        Answer = "To design user interfaces and create a seamless user experience in .NET applications."
                    },
                    new TestAnswer(){
                        Answer = "To facilitate communication between different programming languages within a .NET application."
                    }
                }
            },
            new Test()
{
    Question = "What is the purpose of the 'useState' hook in React Native?",
    CorrectAnswer = "To manage and update state in functional components.",
    Answers = new List<TestAnswer>(){
        new TestAnswer(){
            Answer = "To define and create a new component in React Native."
        },
        new TestAnswer(){
            Answer = "To handle asynchronous operations in React Native components."
        },
        new TestAnswer(){
            Answer = "To control the flow of data between components in a React Native application."
        }
    }
},
new Test()
{
    Question = "What role does the 'TouchableOpacity' component play in React Native?",
    CorrectAnswer = "It provides touchable feedback by reducing the opacity of the wrapped content.",
    Answers = new List<TestAnswer>(){
        new TestAnswer(){
            Answer = "It is used to create animated transitions between screens in React Native."
        },
        new TestAnswer(){
            Answer = "It serves as a container for styling in React Native applications."
        },
        new TestAnswer(){
            Answer = "It is a form component for handling user input in React Native."
        }
    }
},
new Test()
{
    Question = "What is the purpose of the 'useEffect' hook in React Native?",
    CorrectAnswer = "To perform side effects in functional components, such as data fetching or subscriptions.",
    Answers = new List<TestAnswer>(){
        new TestAnswer(){
            Answer = "To define the layout and structure of a React Native component."
        },
        new TestAnswer(){
            Answer = "To handle routing and navigation between screens in a React Native application."
        },
        new TestAnswer(){
            Answer = "To manage and update state in class components."
        }
    }
},
new Test()
{
    Question = "What is the purpose of the 'FlatList' component in React Native?",
    CorrectAnswer = "To render a scrolling list of data with optimal performance.",
    Answers = new List<TestAnswer>(){
        new TestAnswer(){
            Answer = "To create a grid layout for displaying images in React Native."
        },
        new TestAnswer(){
            Answer = "To implement a tab navigation system in React Native applications."
        },
        new TestAnswer(){
            Answer = "To handle user authentication in a React Native project."
        }
    }
},
new Test()
{
    Question = "What is the purpose of the 'React Navigation' library in React Native?",
    CorrectAnswer = "To manage navigation and screen transitions in a React Native app.",
    Answers = new List<TestAnswer>(){
        new TestAnswer(){
            Answer = "To handle state management in React Native applications."
        },
        new TestAnswer(){
            Answer = "To provide a set of UI components for building React Native interfaces."
        },
        new TestAnswer(){
            Answer = "To connect React Native applications with native device features."
        }
    }
},
new Test()
    {
        Question = "What is the primary purpose of Node.js?",
        CorrectAnswer = "To enable server-side JavaScript and build scalable network applications.",
        Answers = new List<TestAnswer>()
        {
            new TestAnswer()
            {
                Answer = "To design responsive and interactive user interfaces in web browsers."
            },
            new TestAnswer()
            {
                Answer = "To create mobile applications using JavaScript and native device features."
            },
            new TestAnswer()
            {
                Answer = "To manage databases and perform CRUD operations on the client-side."
            }
        }
    },
    new Test()
    {
        Question = "What is the Node Package Manager (NPM) used for in Node.js?",
        CorrectAnswer = "To manage and install third-party packages and dependencies for Node.js projects.",
        Answers = new List<TestAnswer>()
        {
            new TestAnswer()
            {
                Answer = "To define the structure and layout of a Node.js application."
            },
            new TestAnswer()
            {
                Answer = "To handle asynchronous operations in Node.js."
            },
            new TestAnswer()
            {
                Answer = "To create and manage virtual environments for Node.js projects."
            }
        }
    },
    new Test()
    {
        Question = "What is the role of the 'Express' framework in Node.js?",
        CorrectAnswer = "To simplify the process of building web applications and APIs with Node.js.",
        Answers = new List<TestAnswer>()
        {
            new TestAnswer()
            {
                Answer = "To perform unit testing for Node.js applications."
            },
            new TestAnswer()
            {
                Answer = "To manage authentication and authorization in Node.js projects."
            },
            new TestAnswer()
            {
                Answer = "To facilitate communication between different servers in a Node.js application."
            }
        }
    },
    new Test()
    {
        Question = "How does Node.js handle asynchronous operations?",
        CorrectAnswer = "By using a non-blocking, event-driven architecture.",
        Answers = new List<TestAnswer>()
        {
            new TestAnswer()
            {
                Answer = "By utilizing multi-threading for parallel execution."
            },
            new TestAnswer()
            {
                Answer = "By implementing synchronous operations to ensure order of execution."
            },
            new TestAnswer()
            {
                Answer = "By relying on the browser's built-in asynchronous capabilities."
            }
        }
    },
    new Test()
    {
        Question = "What is the purpose of the 'fs' module in Node.js?",
        CorrectAnswer = "To handle file system operations, such as reading and writing files.",
        Answers = new List<TestAnswer>()
        {
            new TestAnswer()
            {
                Answer = "To manage front-end styling and design in Node.js applications."
            },
            new TestAnswer()
            {
                Answer = "To establish secure connections between servers in a Node.js project."
            },
            new TestAnswer()
            {
                Answer = "To optimize and compress images in a Node.js application."
            }
        }
    }
        };
    }
}
