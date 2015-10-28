# KubeNET  [![Travis Widget]][Travis]

[![Kubernetes](http://kubernetes.io/img/desktop/nav_logo.svg)](http://kubernetes.io)



[Travis]: https://travis-ci.org/paralin/kubenet
[Travis Widget]: https://travis-ci.org/paralin/KubeNET.svg?branch=master
[Useless]: http://forthebadge.com
[Useless Widget]: http://forthebadge.com/images/badges/contains-cat-gifs.svg

**Kubernetes** is an open source system for managing [containerized applications](https://github.com/kubernetes/kubernetes/wiki/Why-Kubernetes%3F#why-containers) across multiple hosts,
providing basic mechanisms for deployment, maintenance, and scaling of applications.

**KubeNET** allows .NET programs to easily interact with the Kubernetes API, allowing for incredibly complex automations of server clusters in a very simple way.

### Auto-generation

This repository is mostly composed of auto-generated code based on the Kubernetes Swagger API declarations.

Automatic conversions:

 - V1.2 API definitions -> v2.0 API definitions
 - V2.0 Swagger API -> C# code

Unfortuantely there are a few issues/bugs with the code generator for C# and the way the Kubernetes API definitions are written that require some manual editing of the code. Thus, new releases aren't **yet** a single command operation.

### Usage

Coming soon...
