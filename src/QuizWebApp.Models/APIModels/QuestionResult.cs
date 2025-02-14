﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizWebApp.Models.APIModels
{
    public class QuestionResult
    {
        [JsonProperty("results")]
        public List<QuestionInfo> Questions { get; set; } = new List<QuestionInfo>();
    }
}
