﻿using DevAdventCalendarCompetition.Repository.Context;
using DevAdventCalendarCompetition.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevAdventCalendarCompetition.TestResultService.Tests.Models
{
    public class ResultModel
    {
        private readonly UserModel _userModel;

        internal ResultModel(UserModel userModel)
        {
            this._userModel = userModel;
        }

        public List<Result> GetResultList(ApplicationDbContext dbContext)
        {
            if (dbContext is null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            return new List<Result>()
            {
                new Result()
                {
                    Id = 1,
                    UserId = this._userModel.userD.Id,
                    User = this._userModel.userD,
                    Week1Points = 260,
                    Week1Place = 1
                },
                new Result()
                {
                    Id = 2,
                    UserId = this._userModel.userC.Id,
                    User = this._userModel.userC,
                    Week1Points = 260,
                    Week1Place = 2
                },
                new Result()
                {
                    Id = 3,
                    UserId = this._userModel.userA.Id,
                    User = this._userModel.userA,
                    Week1Points = 250,
                    Week1Place = 3
                },
                new Result()
                {
                    Id = 4,
                    UserId = this._userModel.userB.Id,
                    User = this._userModel.userB,
                    Week1Points = 250,
                    Week1Place = 4
                },
                new Result()
                {
                    Id = 5,
                    UserId = this._userModel.userG.Id,
                    User = this._userModel.userG,
                    Week1Points = 250,
                    Week1Place = 5
                },
                new Result()
                {
                    Id = 6,
                    UserId = this._userModel.userH.Id,
                    User = this._userModel.userH,
                    Week1Points = 130,
                    Week1Place = 6
                },
                new Result()
                {
                    Id = 7,
                    UserId = this._userModel.userE.Id,
                    User = this._userModel.userE,
                    Week1Points = 0,
                    Week1Place = 7
                },
                new Result()
                {
                    Id = 8,
                    UserId = this._userModel.userF.Id,
                    User = this._userModel.userF,
                    Week1Points = 0,
                    Week1Place = 8
                },
                new Result()
                {
                    Id = 9,
                    UserId = this._userModel.userI.Id,
                    User = this._userModel.userI,
                    Week1Points = 0,
                    Week1Place = 9
                }
            };
        }
    }
}