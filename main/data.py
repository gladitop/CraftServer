from enum import Enum

class data:
    class ConfigServer:
        NameServer = ""
        CoreServer = ""

        def __init__(nameServer, coreServer):
            
            NameServer = nameServer
            CoreServer = coreServer

    class CoreServer(Enum):
        Spigot = 1,
        CraftBukkit = 2