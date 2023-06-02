using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarketMentor.Data;
using AutoMapper;
using MarketMentor.Models;
using MarketMentor.Contracts;
using Microsoft.AspNetCore.Authorization;
using MarketMentor.Constant;

namespace MarketMentor.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper,
            ILeaveAllocationRepository leaveAllocationRepository)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var leaveTypes = mapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync());
            return View(leaveTypes);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            var leaveTypes = await leaveTypeRepository.GetAsync(id.Value);
            if (leaveTypes == null)
            {
                return NotFound();
            }

            var leaveTypesVM = mapper.Map<LeaveTypeVM>(leaveTypes);
            return View(leaveTypesVM);
        }

        // GET: LeaveTypes/Create

        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(LeaveTypeVM leaveTypesVM)
        {
            if (ModelState.IsValid)
            {
                var leaveTypes = mapper.Map<LeaveTypes>(leaveTypesVM);
                await leaveTypeRepository.AddAsync(leaveTypes);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypesVM);
        }

        // GET: LeaveTypes/Edit/5

        public async Task<IActionResult> Edit(int? id)
        {
            var leaveTypes = await leaveTypeRepository.GetAsync(id.Value);
            if (leaveTypes == null)
            {
                return NotFound();
            }

            var leaveTypesVM = mapper.Map<LeaveTypeVM>(leaveTypes);
            return View(leaveTypesVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveTypes = mapper.Map<LeaveTypes>(leaveTypeVM);
                    await leaveTypeRepository.UpdateAsync(leaveTypes);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypeRepository.Exists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(int id)
        {
            await leaveAllocationRepository.LeaveAllocation(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
