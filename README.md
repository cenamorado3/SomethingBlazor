# magmutual
What did you think of the project?
It was a simple project the demonstrates some degree of working knowledge of the leveraged technlogies.


What didn’t you like about the project?
I limited my time on it and labeled it as "good enough." There is no persistance to a database, it is very dry, I spent far to much time wanting to make things pixel 
perfect. Though truthfully I would not want to, and generally do not go that far on take home project that are part of an interview process.


How would you change the project or approach?
In this pure of a form, not much if anything at all. At scale, not using hard coded list, leveraging a database in its stead. Seperating the code implemented in the Hub, 
to task based libraries in order to leverage SOLID design principles and other architecture patterns. In general, making the front end elegant.


Anything else you would like to share?
I'd like to at least ramble for a few sentences on the technlogies used and why.

I chose to do this using C# .NETCore 6 and Blazor. Not only because it was mentioned in the initial phone screen, but also because it is what I have most recently used 
for work. On a more personal note, I really enjoy it's use of new and bleeding edge technlogy with a positive outlook on the future. Specifically websockets which leads
to blazing fast communications when compred to the existing HTTP/HTTPS standard. To dive into a bit more detail, when a page is visited, it makes an HTTP request to 
Upgrade the connection to a websocket, older systems may not support it, in which case, it falls back existing HTTP/HTTPS standards, otherwise the steps are taken to 
perform the SSL Handshake securing the connection, finally upgrading after both client and server acknlowedge the request and response.

Moving forward both the client is able to invoke existing server functions, and the server is able to send data to the client caller or all clients, all over a secure
websocket. To me, that is simply fascinating.
