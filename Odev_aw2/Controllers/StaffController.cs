using Microsoft.AspNetCore.Mvc;
using Odev_aw2.Data.EntityLayer;
using Odev_aw2.Data.UnitOfWork;

namespace Odev_aw2.Controllers;


[Route("odev_aw2/v1/[controller]")]
[ApiController]
public class StaffController
{
    private readonly IUnitOfWork unitOfWork;
    public StaffController(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }
    [HttpGet]
    public List<Staff> GetAll()
    {
        var list = unitOfWork.StaffRepository.GetAll();
        return list;
    }
    [HttpGet("Country")]
    public List<Staff> GetCountry([FromQuery] string country)
    {
        var list = unitOfWork.StaffRepository.GetAll();
        return list;
    }

    [HttpGet("{id}")]
    public Staff GetById(int id)
    {
        var row = unitOfWork.StaffRepository.GetById(id);
        return row;
    }

    [HttpPost]
    public void Post([FromBody] Staff staff)
    {
        unitOfWork.StaffRepository.Insert(staff);
        unitOfWork.Complate();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Staff staff)
    {
        staff.Id = id;
        unitOfWork.StaffRepository.Insert(staff); 
        unitOfWork.Complate();
      
    }


    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        unitOfWork.StaffRepository.DeleteById(id);
        unitOfWork.Complate();
    }
}
