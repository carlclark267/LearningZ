# Calling with positional parameters
# .\Parameters.ps1 MyInstance 10

# Calling with named parameters
# .\Parameters.ps1 -retentionDays 20 -instanceName MySecondInstance

param
(
    # Name of the instance
    [string]$instanceName="default",

    # Number of days to retain
    [int]$retentionDays=5
)

Write-Host "Parameter: instanceName=$instanceName retentionDays=$retentionDays"