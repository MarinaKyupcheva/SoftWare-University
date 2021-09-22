using System;
using System.Collections.Generic;
using System.Linq;

namespace _10SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", " ).ToList();

            string command = Console.ReadLine();

            while(command != "course start")
            {
                string[] cmdArgs = command.Split(":").ToArray();
                string firstCommand = cmdArgs[0];
                string lessonTitle = cmdArgs[1];


                if (firstCommand == "Add")
                {
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                    }
                    
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Insert(index, lessonTitle);
                    }
                }
                else if (firstCommand == "Remove")
                {
                    if (lessons.Contains(lessonTitle))
                    {
                        lessons.Remove(lessonTitle);
                    }
                }
                else if (firstCommand == "Swap")
                {
                    string secondLessonTitle = cmdArgs[2];
                    int indexOfLessonTitle = lessons.IndexOf(lessonTitle);
                    int indexOfSecondLessonTitle = lessons.IndexOf(secondLessonTitle);

                    if (indexOfLessonTitle != - 1 && indexOfSecondLessonTitle != -1)
                   
                    {
                        lessons[indexOfLessonTitle] = secondLessonTitle;
                        lessons[indexOfSecondLessonTitle] = lessonTitle;

                       string firstLessonExercise = $"{lessonTitle}-Exercise";
                       int indexOfFirstLessonExercise = indexOfLessonTitle + 1 ;
                    
                     
                       if(indexOfLessonTitle < lessons.Count && 
                           lessons[indexOfFirstLessonExercise] == firstLessonExercise)
                       {
                           lessons.RemoveAt(indexOfFirstLessonExercise);
                           indexOfFirstLessonExercise = lessons.IndexOf(lessonTitle);
                           lessons.Insert(indexOfFirstLessonExercise, firstLessonExercise);
                    
                       }
                       string secondLessonExercise = $"{secondLessonTitle}-Exercise";
                       int indexOfSecondLessonExercise = indexOfSecondLessonTitle + 1;
                    
                       if (indexOfSecondLessonTitle < lessons.Count &&
                           lessons[indexOfSecondLessonExercise] == secondLessonExercise)
                      {
                          lessons.RemoveAt(indexOfSecondLessonTitle + 1);
                            indexOfSecondLessonTitle = lessons.IndexOf(secondLessonTitle);
                          lessons.Insert(indexOfSecondLessonTitle + 1, secondLessonExercise);
                    
                      }
                    
                    
                    }
                    else if(firstCommand == "Exercise")
                    {
                        int index = lessons.IndexOf(lessonTitle);
                        string exercise = $"{lessonTitle}-Exercise";

                        bool isThereLesson = lessons.Contains(lessonTitle);
                        bool isThereExersice = lessons.Contains(exercise);
                        if (isThereLesson && !isThereExersice)
                        {
                            lessons.Insert(index + 1, exercise);
                        }
                        else if (!isThereLesson)
                        {
                            lessons.Add(lessonTitle);
                            lessons.Add(exercise);
                        }

                    }


                }


                command = Console.ReadLine();
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
