﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task5
{
    static class Constants
    {
        public const int workDay = 8; //work day length in hours;
        
        public const string enterTask = "Please, enter your task description:";
        public const string enterTaskPriority = "Please, enter task priority, where 1 - High, 2 - Medium, 3 - Low:";
        public const string errorTaskPriorityIsWrong = "Enetered priority value is wrong. Please, try again.";

        public const string enterTaskDifficulty = "Please, enter task difficulty:";
        public const string errorTaskDifficultyIsWrong = "Enetered difficulty value is wrong.Please, try again.";

        public const string enterAmountOfDays = "Please, enter amount of days:";
        public const string errorAmountOfDaysIsWrong = "Entered amount of days is wrong. Please, enter correct amount of days again.";
    }
}