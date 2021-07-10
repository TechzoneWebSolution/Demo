﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Common;
using Demo.Common.Paging;
using Demo.Entities.Contract;

namespace Demo.Services.Contract
{
    public abstract class AbstractExamStandardServices : AbstractBaseService
    {
        public abstract SuccessResult<AbstractExamStandard> ExamStandardUpsert(AbstractExamStandard abstractExam);

        public abstract PagedList<AbstractExamStandard> ExamStandardSelectAll(PageParam pageParam, string search);

        public abstract bool ExamStandardDelete(string StandardKey);

        public abstract SuccessResult<AbstractExamStandard> ExamStandardById(string StandardKey);

    }
}
