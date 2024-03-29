﻿using CSQLtesttask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CSQLtesttask.Controllers
{
    [RoutePrefix("api/tasks")]
    public class TasksController : ApiController
    {
        private readonly DbModel _db;

        public TasksController()
        {
            _db = new DbModel();
        }

        /// <summary>
        /// Find clients that do not consume any service.
        /// </summary>
        /// <returns></returns>
        [Route("task4")]
        public async Task<IEnumerable<vw_Task4>> GetTask4()
        {
            return await _db.vw_Task4.ToArrayAsync();
        }

        /// <summary>
        /// Find all clients that consume S1​ or S2​ services.
        /// </summary>
        /// <returns></returns>
        [Route("task5")]
        public async Task<IEnumerable<vw_Task5>> GetTask5()
        {
            return await _db.vw_Task5.ToArrayAsync();
        }

        /// <summary>
        /// Find all clients that consume S​1​ ​and​ ​S​2​ services. 
        /// </summary>
        /// <returns></returns>
        [Route("task6")]
        public async Task<IEnumerable<vw_Task6>> GetTask6()
        {
            return await _db.vw_Task6.ToArrayAsync();
        }

        /// <summary>
        /// Find all clients that consume only S​1​ ​and​ ​S​2​ services.
        /// </summary>
        /// <returns></returns>
        [Route("task7")]
        public async Task<IEnumerable<vw_Task7>> GetTask7()
        {
            return await _db.vw_Task7.ToArrayAsync();
        }

        /// <summary>
        /// Find all clients that do not consume S​1 ​service.
        /// </summary>
        /// <returns></returns>
        [Route("task8")]
        public async Task<IEnumerable<vw_Task8>> GetTask8()
        {
            return await _db.vw_Task8.ToArrayAsync();
        }

        /// <summary>
        /// Find all clients that consume S​1​ service but do not consume S​2 ​service.
        /// </summary>
        /// <returns></returns>
        [Route("task9")]
        public async Task<IEnumerable<vw_Task9>> GetTask9()
        {
            return await _db.vw_Task9.ToArrayAsync();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            _db.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
