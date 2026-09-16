# CoffeeNChill-API
This is an API that I designed to use DockerHub to run an instance of it on the cloud just by some one else having downloaded docker. It shows my usage of Functions familiarity and containerization.

# How to run it on Docker.
You would first need to have docker installed and working both on the client and server side.
Then run these commands:

1. docker network create coffeenchill-network (This creates the network that the azurite and functions app would use to communicate which other.)
2. docker run -d --name coffeenchill-azurite --network coffeenchill-network --restart unless-stopped -p 10000:10000 -p 10001:10001 -p 10002:10002 -v c:\azurite-docker-data:/data mcr.microsoft.com/azure-storage/azurite azurite --location /data --blobHost 0.0.0.0 --queueHost 0.0.0.0 --tableHost 0.0.0.0 --skipApiVersionCheck
(To be fair, alot of parameters here arent really compulsory, they aer just safety checks to increase the chances of it actually running. The code itself creates a container for an azurite instance and connects with the network u created earlier.)
3. docker run -d --name coffeenchill --network coffeenchill-network -p 7071:80 -e AzureWebJobsStorage="DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://coffeenchill-azurite:10000/devstoreaccount1;QueueEndpoint=http://coffeenchill-azurite:10001/devstoreaccount1;TableEndpoint=http://coffeenchill-azurite:10002/devstoreaccount1;" michael3z3/coffeenchill-functions:v1.0

(This finds, selects and installs an image and its corresponding container, sharing the same network as the one u made earlier, using "michael3z3/coffeenchill-functions:v1.0". This is my own image that i uploaded on github.)
After all these work, without errors hopefully, it should give u give some local endpoints that u can verify in postman. The endpoints in the dockerFile were made to use port 7071 on the local computer and then 80 on the virtual container. The "80" is meaningless in this context dont mind me. The query should look something like this:

METHOD: GET
URL:    http://localhost:7071/api/menu
If u dont know anything about APIs just skip this repo in general broski 😭😭
