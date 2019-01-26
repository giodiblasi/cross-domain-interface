# Using C# Extension Methods for Cross Domain behaviors

Sometimes we would like to add cross domain behaviors to our domain types.  
Think about aspects like:
+ Messaging
+ Logging

In fact these are not aspects of a specifc domain of our project, but they could be used across the all domains.
Imagine a classic Publisher-Subscriber system, we can easly define two roles: Subscriber and Publisher with methods "Subscribe" and "Publish".
But how can I add these behaviors to our domain types?

Read the [related post](https://medium.com/@gio.diblasi/cross-domain-behaviors-dont-panic-1fba8417ac70) for more details.