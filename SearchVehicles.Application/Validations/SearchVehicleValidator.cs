using FluentValidation;
using SearchVehicles.Domain.DTO.SearchVehicles.Input;
using static SearchVehicles.Domain.Constants;

namespace SearchVehicles.Application.Validations
{
    public class SearchVehicleValidator : AbstractValidator<SearchVehicleInput>
    {
        public SearchVehicleValidator()
        {
            RuleFor(x => x.LocalityCollectionId)
                .NotEmpty()
                .NotNull()
                .WithMessage(MESSAGE_ID_LOCATION_COLLECTION_NULL)
                .WithErrorCode(ERROR_CODE_ID_LOCATION_COLLECTION_NULL);

            RuleFor(x => x.LocalityReturnId)
                .NotEmpty()
                .NotNull()
                .WithMessage(MESSAGE_ID_LOCATION_RETURN_NULL)
                .WithErrorCode(ERROR_CODE_ID_LOCATION_RETURN_NULL);
        }
    }
}