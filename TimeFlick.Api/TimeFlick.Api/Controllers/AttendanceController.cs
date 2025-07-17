using Microsoft.AspNetCore.Mvc;
using TimeFlick.Application.Services;
using TimeFlick.Core.Entities;
using TimeFlick.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimeFlick.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IPdfGenerator _pdfGenerator;
        private readonly IPersonService _personService;
        public AttendanceController(IPdfGenerator pdfGenerator, IPersonService personService)
        {
            _pdfGenerator = pdfGenerator;
            _personService = personService;
        }
        [HttpGet("report/download")]
        public IActionResult Download()
        {
            string htmlContent = @"
<!DOCTYPE html>
<html lang='en'>
<head>
  <meta charset='UTF-8'>
  <title>Executive Salary Sheet - Jun 2025</title>
  <style>
    body {
      font-family: Arial, sans-serif;
      font-size: 12px;
    }
    table {
      width: 100%;
      border-collapse: collapse;
      table-layout: fixed;
      border: 2px solid #000;
    }
    th, td {
      border: 2px solid #000;
      padding: 3px;
      text-align: center;
      word-wrap: break-word;
    }
    .text-left {
      text-align: left;
    }
    .print-btn {
      margin: 20px;
    }
    .title, .subtitle, .section-title {
      text-align: center;
      margin: 5px 0;
    }
    .title {
      font-weight: bold;
      font-size: 16px;
    }
    .subtitle {
      font-size: 13px;
    }
    .section-title {
      font-weight: bold;
    }
    @media print {
      @page {
        size: A4 landscape;
        margin: 5mm;
      }
      body {
        font-size: 11px;
        margin: 0;
      }
      .print-btn {
        display: none;
      }
      html, body {
        display: block;
      }
    }
  </style>
</head>
<body>

  <div class='title'>ABR SPINNING MILLS LIMITED</div>
  <div class='subtitle'>House# 10, (Lift-7) Road-90, Gulshan-2, Dhaka-1212</div>
  <div class='subtitle'>Executive Salary Sheet of Jun-2025 [ 2025-06-01 to 2025-06-30 ]</div>
  <div>Department : HR, Admin & Compliance</div>

  <table>
    <thead>
      <tr>
        <th rowspan='3'>SL</th>
        <th rowspan='3'>Emp ID</th>
        <th rowspan='3'>Name</th>
        <th rowspan='3'>Section</th>
        <th rowspan='3'><div style='transform: rotate(-90deg); writing-mode: vertical-rl; white-space: nowrap;'>Designation</div></th>
        <th rowspan='3'>Join Date</th>
        <th rowspan='3'>Grade</th>
        <th colspan='4'>Gross Salary</th>
        <th rowspan='3'>Gross Salary</th>
        <th colspan='6'>Working Days</th>
        <th colspan='3'>Leave</th>
        <th rowspan='3'>Payable Days</th>
        <th colspan='4'>Deductions</th>
        <th rowspan='3'>Payable Salary</th>
        <th rowspan='3'>Att. Bonus</th>
        <th rowspan='3'>Stamp</th>
        <th rowspan='3'>Net Pay</th>
        <th rowspan='3'>Signature</th>
        <th rowspan='3'>Photo</th>
      </tr>
      <tr>
        <th>Basic Salary</th>
        <th>Home Rent</th>
        <th>Transport</th>
        <th>Medical</th>
        <th>W.D</th>
        <th>Weekend</th>
        <th>Holiday</th>
        <th>Present</th>
        <th>Absent</th>
        <th>Late days</th>
        <th>CL</th>
        <th>SL</th>
        <th>EL</th>
        <th>Absent</th>
        <th>Late</th>
        <th>Advance</th>
        <th>Others</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>1</td>
        <td>2145<br>(100003)</td>
        <td class='text-left'>Noni Gopal Biswas</td>
        <td>HR, Admin & Com</td>
        <td>Asst. General Man</td>
        <td>01-01-2022</td>
        <td>9th</td>
        <td>30031</td>
        <td>16817</td>
        <td>3003</td>
        <td>4505</td>
        <td>60061</td>
        <td>30</td>
        <td>4</td>
        <td>4</td>
        <td>17</td>
        <td>5</td>
        <td>10</td>
        <td>0</td>
        <td>0</td>
        <td>25</td>
        <td>5005</td>
        <td>3003</td>
        <td>0</td>
        <td>0</td>
        <td>52053</td>
        <td>500</td>
        <td>10</td>
        <td>52543</td>
        <td></td>
        <td></td>
        <td><img src='nipun.jpg' style='height:40px;' /></td>
      </tr>
      <tr>
        <td>2</td>
        <td>2025<br>(100045)</td>
        <td class='text-left'>Md. Rasel Rana</td>
        <td>HR, Admin & Com</td>
        <td>Asst. Manager</td>
        <td>01-12-2023</td>
        <td>3rd</td>
        <td>14753</td>
        <td>8261</td>
        <td>1475</td>
        <td>2213</td>
        <td>29505</td>
        <td>30</td>
        <td>3</td>
        <td>4</td>
        <td>14</td>
        <td>9</td>
        <td>5</td>
        <td>0</td>
        <td>0</td>
        <td>21</td>
        <td>8852</td>
        <td>492</td>
        <td>0</td>
        <td>0</td>
        <td>20161</td>
        <td>500</td>
        <td>0</td>
        <td>20661</td>
        <td></td>
        <td></td>
        <td><img src='nipun.jpg' style='height:40px;' /></td>
      </tr>
      <tr>
        <td colspan='11' class='text-left'><strong>Manpower : 2</strong></td>
        <td><strong>89566</strong></td>
        <td colspan='8'></td>
        <td><strong>13857</strong></td>
        <td><strong>3495</strong></td>
        <td><strong>0</strong></td>
        <td><strong>0</strong></td>
        <td><strong>72214</strong></td>
        <td><strong>1000</strong></td>
        <td><strong>10</strong></td>
        <td><strong>73204</strong></td>
        <td></td>
        <td></td>
      </tr>
    </tbody>
  </table>
</body>
</html>
";


            var pdfBytes = _pdfGenerator.GeneratePdfFromHtml(htmlContent);
            return File(pdfBytes, "application/pdf", "AttendanceReport.pdf");
        }
        // GET: api/<AttendanceController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await _personService.GetAllAsync();
            return Ok(persons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var person = await _personService.GetByIdAsync(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            await _personService.AddAsync(person);
            return CreatedAtAction(nameof(Get), new { id = person.Id }, person);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Person person)
        {
            if (id != person.Id) return BadRequest();

            await _personService.UpdateAsync(person);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _personService.RemoveAsync(id);
            return NoContent();
        }

        [HttpGet("code/{personCode}")]
        public async Task<IActionResult> GetByCode(string personCode)
        {
            var person = await _personService.GetByPersonCodeAsync(personCode);
            if (person == null) return NotFound();
            return Ok(person);
        }
    }
}
