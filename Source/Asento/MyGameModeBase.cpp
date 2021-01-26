


#include "MyGameModeBase.h"
#include "../Plugins/FMODStudio/Source/FMODStudio/Public/FMODStudioModule.h"

AMyGameModeBase::AMyGameModeBase()
{
	(void)IFMODStudioModule::Get();
}
