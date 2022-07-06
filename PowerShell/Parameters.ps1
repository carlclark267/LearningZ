# Calling with positional parameters
# .\Parameters.ps1 MyInstance 10 Yes

# Calling with named parameters
# .\Parameters.ps1 -retentionDays 20 -instanceName MySecondInstance -mustHave No

# Calling with named parameters parameter validation will fail.
# .\Parameters.ps1 -retentionDays 20 -instanceName MySecondInstance

param
(
    # Name of the instance
    [string]$instanceName="default",

    # Number of days to retain
    [int]$retentionDays=5,

    [string]$mustHave
)

# Function Definitions *************************************
function ValidateParameters
{
    # Validate the required parameters and provide a friendly error message
    if ($mustHave -eq "")
    {
        Write-Host "A value must be provided for the -mustHave parameter." -ForegroundColor Red
        return $False
    }
    return $True
}
# **********************************************************

$areParametersValid = ValidateParameters
if ($areParametersValid -ne $True)
{
    exit(-1)
}

Write-Host "Parameter: instanceName=$instanceName retentionDays=$retentionDays mustHave=$mustHave"


