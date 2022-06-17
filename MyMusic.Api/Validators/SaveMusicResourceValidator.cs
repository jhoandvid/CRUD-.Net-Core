using System.Data;
using FluentValidation;
using MyMusic.Api.Resources;
using MyMusic.Core.Models;

namespace MyMusic.Api.Validators
{
    public class SaveMusicResourceValidator : AbstractValidator<SaveMusicResource>
    
    {
        public SaveMusicResourceValidator()
        {
            RuleFor(m => m.Name).NotEmpty().MaximumLength(50);
            RuleFor(m => m.ArtistId).NotEmpty().WithMessage("'Artist Id' must not be o");
        }
    
    }
}