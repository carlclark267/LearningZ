# Docker
## Topics
* [ ] Docker

## References
* [Dockerizing a Node.js web app](https://nodejs.org/en/docs/guides/nodejs-docker-webapp/).
* [Create Angular App and Deploy it to Docker Hub](https://www.youtube.com/watch?v=etA5xiX5TCA&list=PL8tjXaWtotjO8rubGqVDALeAiXKyiFyeD&index=2&t=595s).
* Use the Visual Studio Code Docker tools - they help!

## Quick Start
* [Docker CLI documentation](https://docs.docker.com/engine/reference/run/).
* List running containers - `docker ps`
* Stop a running container - `docker stop [[ContainerID or Name]]`
* List images - `docker images`
* Remove an image - `docker image rm [[Name:Tag]]` or `docker image rm [[Name:Tag]] --force`
* Build an image - `docker build --rm --file "dockerfile" --tag MyDockerImage:v1 "."`
* Run an image - `docker run --rm --detach --publish 82:80/tcp MyDockerImage:v1`
