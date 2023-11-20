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
            }
        };
    }
}
