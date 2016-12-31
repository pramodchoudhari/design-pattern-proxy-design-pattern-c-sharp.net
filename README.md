# Design Pattern Proxy Design Pattern C# .Net
This repository explains what is proxy design pattern and its example in c-sharp .net

#What is the Proxy Design Pattern?
The proxy design pattern helps you to provide an interface to other objects by creating proxy class which acts as wrapper. This wrapper provides limited access to objects. There could following reasons to use Proxy Design Pattern
1. Due to security reason you have to provide limited access to some functionality. 
2. Object creation is intensive.
3. Providing interface for remote resources, such as web service or REST resources.

#Who is what?
The classes, interfaces and objects in the Proxy Pattern can be identified as follows:
1. IClient- Subject Interface.
2. RealClient - RealSubject Class.
3. ProxyClient - Proxy Class.
