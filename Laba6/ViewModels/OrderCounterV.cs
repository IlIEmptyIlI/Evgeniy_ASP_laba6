using System.ComponentModel.DataAnnotations;
namespace Laba6.ViewModels
{
    public record class OrderCounterV([Required][Range(0, int.MaxValue, ErrorMessage = "It's must be a non-negative number.")] string Count);
}