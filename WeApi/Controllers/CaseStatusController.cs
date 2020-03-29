﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeApi.Entitties;

namespace WeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseStatusController : ControllerBase
    {
        private readonly DataContext _context;

        public CaseStatusController(DataContext context)
        {
            _context = context;
        }

        // GET: api/CaseStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CaseStatus>>> GetCaseStatuses()
        {
            return await _context.CaseStatuses.ToListAsync();
        }

        // GET: api/CaseStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CaseStatus>> GetCaseStatus(int id)
        {
            var caseStatus = await _context.CaseStatuses.FindAsync(id);

            if (caseStatus == null)
            {
                return NotFound();
            }

            return caseStatus;
        }

        // PUT: api/CaseStatus/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut]
        public async Task<IActionResult> PutCaseStatus(CaseStatus caseStatus)
        {
            _context.Entry(caseStatus).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // POST: api/CaseStatus
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CaseStatus>> PostCaseStatus(CaseStatus caseStatus)
        {
            _context.CaseStatuses.Add(caseStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCaseStatus", new { id = caseStatus.Id }, caseStatus);
        }

        // DELETE: api/CaseStatus/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CaseStatus>> DeleteCaseStatus(int id)
        {
            var caseStatus = await _context.CaseStatuses.FindAsync(id);
            if (caseStatus == null)
            {
                return NotFound();
            }

            _context.CaseStatuses.Remove(caseStatus);
            await _context.SaveChangesAsync();

            return caseStatus;
        }

        private bool CaseStatusExists(int id)
        {
            return _context.CaseStatuses.Any(e => e.Id == id);
        }
    }
}
