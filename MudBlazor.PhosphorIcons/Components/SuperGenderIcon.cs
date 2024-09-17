using static MudBlazor.Phosphor.GenderValue;

namespace MudBlazor.Phosphor;

public class SuperGenderIcon : SuperIcon
{
    [Parameter]
    public GenderValue Value { get; set; } = Male;
    
    public override string GetIcon()
    {
        return (Weight, Value) switch
        {
            // Regular
            (Regular, Male) => PhosphorRegular.GenderMale,
            (Regular, Female) => PhosphorRegular.GenderFemale,
            (Regular, Neuter) => PhosphorRegular.GenderNeuter,
            (Regular, NonBinary) => PhosphorRegular.GenderNonbinary,
            (Regular, Intersex) => PhosphorRegular.GenderIntersex,
            (Regular, Transgender) => PhosphorRegular.GenderTransgender,
            // Thin
            (Thin, Male) => PhosphorThin.GenderMale,
            (Thin, Female) => PhosphorThin.GenderFemale,
            (Thin, Neuter) => PhosphorThin.GenderNeuter,
            (Thin, NonBinary) => PhosphorThin.GenderNonbinary,
            (Thin, Intersex) => PhosphorThin.GenderIntersex,
            (Thin, Transgender) => PhosphorThin.GenderTransgender,
            // Light
            (Light, Male) => PhosphorLight.GenderMale,
            (Light, Female) => PhosphorLight.GenderFemale,
            (Light, Neuter) => PhosphorLight.GenderNeuter,
            (Light, NonBinary) => PhosphorLight.GenderNonbinary,
            (Light, Intersex) => PhosphorLight.GenderIntersex,
            (Light, Transgender) => PhosphorLight.GenderTransgender,
            // Bold
            (Bold, Male) => PhosphorBold.GenderMale,
            (Bold, Female) => PhosphorBold.GenderFemale,
            (Bold, Neuter) => PhosphorBold.GenderNeuter,
            (Bold, NonBinary) => PhosphorBold.GenderNonbinary,
            (Bold, Intersex) => PhosphorBold.GenderIntersex,
            (Bold, Transgender) => PhosphorBold.GenderTransgender,
            // Fill
            (Fill, Male) => PhosphorFill.GenderMale,
            (Fill, Female) => PhosphorFill.GenderFemale,
            (Fill, Neuter) => PhosphorFill.GenderNeuter,
            (Fill, NonBinary) => PhosphorFill.GenderNonbinary,
            (Fill, Intersex) => PhosphorFill.GenderIntersex,
            (Fill, Transgender) => PhosphorFill.GenderTransgender,
            // Duotone
            (Duotone, Male) => PhosphorDuotone.GenderMale,
            (Duotone, Female) => PhosphorDuotone.GenderFemale,
            (Duotone, Neuter) => PhosphorDuotone.GenderNeuter,
            (Duotone, NonBinary) => PhosphorDuotone.GenderNonbinary,
            (Duotone, Intersex) => PhosphorDuotone.GenderIntersex,
            (Duotone, Transgender) => PhosphorDuotone.GenderTransgender,
            _ => PhosphorRegular.GenderMale, // Default case
        };
    }
}

public enum GenderValue
{
    Male,
    Female,
    Neuter,
    NonBinary,
    Intersex,
    Transgender
}
