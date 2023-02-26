using QuizApp.Model;

namespace QuizApp.Data
{
    public static class QuizData
    {
        public static List<Player> Players = new List<Player> {
            new Player()
            {
                Id = 0,
                UserName = "Demen",
                Level = 0,
                Experience = 0,
                quizzes = new List<Quiz> {
                    new Quiz { Id = 1, Name = "Science Quiz",
                        Questions = new List<Question>{
                            new Question { Id = 0, QuestionString = "What is the number Pi?",
                                Answers = new List<Answer>{
                                    new Answer { Id = 0, AnswerString = "2.14", isCorrect = false },
                                    new Answer { Id = 1, AnswerString = "2.65", isCorrect = false},
                                    new Answer { Id = 2, AnswerString = "3.14", isCorrect = true} }  },
                            new Question { Id = 1, QuestionString = "How much does the earth weigh?",
                                Answers = new List<Answer>{
                                    new Answer { Id = 0, AnswerString = "2kg", isCorrect = false },
                                    new Answer { Id = 1, AnswerString = "5.972 × 10^21kg", isCorrect = false },
                                    new Answer { Id = 2, AnswerString = "5.972 × 10^21mg", isCorrect = false },
                                    new Answer { Id = 3, AnswerString = "2t", isCorrect = false },
                                    new Answer { Id = 4, AnswerString = "5.972 × 10^21t", isCorrect = true },
                                    new Answer { Id = 5, AnswerString = "2mg", isCorrect = false },
                                    new Answer { Id = 6, AnswerString = "5.972 × 10^24kg", isCorrect = true }
                                }
                            },
                            new Question { Id = 2, QuestionString = "How far away is the sun?",
                                Answers = new List<Answer>{
                                    new Answer { Id = 0, AnswerString = "93 million miles", isCorrect = true},
                                    new Answer { Id = 1, AnswerString = "0.000015603 light years", isCorrect = true},
                                    new Answer { Id = 2, AnswerString = "147.62 million km", isCorrect = true},
                                    new Answer { Id = 3, AnswerString = "163604549431.32 yd", isCorrect = true},
                                    new Answer { Id = 4, AnswerString = "484.3 billion′", isCorrect = true},
                                    new Answer { Id = 5, AnswerString = "147.62 billion m", isCorrect = true},
                                    new Answer { Id = 6, AnswerString = "123.017 billion washing machines", isCorrect = true},
                                    new Answer { Id = 7, AnswerString = "1.406 billion footbal fields", isCorrect = true}
                                }
                            }
                        }
                    },
                    new Quiz { Id = 2, Name = "Personal Quiz",
                        Questions = new List<Question>{
                            new Question { Id = 0, QuestionString = "What is your name?",
                                Answers = new List<Answer> {
                                    new Answer { Id = 0, AnswerString="Laci", isCorrect = false },
                                    new Answer { Id = 1, AnswerString="Matyi", isCorrect = false },
                                    new Answer { Id = 2, AnswerString="Manyi", isCorrect = false },
                                    new Answer { Id = 3, AnswerString="Kati", isCorrect = false },
                                    new Answer { Id = 4, AnswerString="Ador", isCorrect = true }
                                }
                            },
                            new Question { Id = 1, QuestionString = "How old are you?",
                                Answers = new List<Answer> {
                                    new Answer { Id = 0, AnswerString="13", isCorrect = false },
                                    new Answer { Id = 1, AnswerString="23", isCorrect = true },
                                    new Answer { Id = 2, AnswerString="32", isCorrect = false },
                                    new Answer { Id = 3, AnswerString="40", isCorrect = false }
                                }
                            },
                            new Question { Id = 2, QuestionString = "How many brothers/sisters do you have?",
                                Answers = new List<Answer> {
                                    new Answer { Id = 0, AnswerString="1", isCorrect = false },
                                    new Answer { Id = 1, AnswerString="0", isCorrect = false },
                                    new Answer { Id = 2, AnswerString="2", isCorrect = true }
                                }
                            },
                            new Question { Id = 3, QuestionString = "Where do you live?",
                                Answers = new List<Answer> {
                                    new Answer { Id = 0, AnswerString="Suseni, Mures", isCorrect = true },
                                    new Answer { Id = 1, AnswerString="Suseni, Miercurea Ciuc", isCorrect = false },
                                    new Answer { Id = 2, AnswerString="Suseni, Mures, Transylvania", isCorrect = true },
                                    new Answer { Id = 3, AnswerString="Suseni, Mures, Romania", isCorrect = true },
                                    new Answer { Id = 4, AnswerString="Suseni, Pensylvania, America", isCorrect = false }
                                }
                            },
                            new Question { Id = 4, QuestionString = "What is your faorite color?",
                                Answers = new List<Answer> {
                                    new Answer { Id = 0, AnswerString="Blue", isCorrect = true },
                                    new Answer { Id = 1, AnswerString="Red", isCorrect = true },
                                    new Answer { Id = 2, AnswerString="Green", isCorrect = true }
                                }
                            },
                            new Question { Id = 5, QuestionString = "Where you were born?",
                                Answers = new List<Answer> {
                                    new Answer { Id = 0, AnswerString="Reghin, Mures", isCorrect = true },
                                    new Answer { Id = 1, AnswerString="Odorheiu Secuiesc, Harghita", isCorrect = false },
                                    new Answer { Id = 2, AnswerString="Petelea, Mures", isCorrect = false }
                                }
                            },
                            new Question { Id = 6, QuestionString = "In wich university did you graduate?",
                                Answers = new List<Answer> {
                                    new Answer { Id = 0, AnswerString="MIT", isCorrect = false },
                                    new Answer { Id = 1, AnswerString="HARVARD", isCorrect = false },
                                    new Answer { Id = 2, AnswerString="CALTECH", isCorrect = false },
                                    new Answer { Id = 3, AnswerString="Sapientia", isCorrect = true }
                                }
                            },
                            new Question { Id = 7, QuestionString = "What fast food do you like?",
                                Answers = new List<Answer> {
                                    new Answer { Id = 0, AnswerString="Pizza", isCorrect = true },
                                    new Answer { Id = 1, AnswerString="HotDog", isCorrect = true },
                                    new Answer { Id = 2, AnswerString="Shwarma", isCorrect = true },
                                    new Answer { Id = 3, AnswerString="DogShit", isCorrect = false },
                                    new Answer { Id = 4, AnswerString="Doughnut", isCorrect = true }
                                }
                            }
                        }
                    }
                }
            },
            new Player()
            {
                Id = 1,
                UserName = "Test",
                Level = 3,
                Experience = 2000,
                quizzes = new List<Quiz>()
            }
        };
    }
}
