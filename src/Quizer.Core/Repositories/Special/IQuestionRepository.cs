﻿using Quizer.Models.Entities;

namespace Quizer.Core.Repositories.Special
{
    public interface IQuestionRepository : IRepository<Question>
    {
        public bool IsCorrect(Guid questionId, Guid answerId);


    }
}
