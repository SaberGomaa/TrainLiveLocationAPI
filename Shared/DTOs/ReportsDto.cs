using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public record ReportWithoutchiledForManipulationDto
    {
        public string? Descreption { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public int PostId { get; set; }
    }
    public record ReportDto(int id ,string? Descreption , int UserId , int postId);

    public record ReportCreationDto : ReportWithoutchiledForManipulationDto;

    public record ReportUpdateDto : ReportWithoutchiledForManipulationDto;
}
