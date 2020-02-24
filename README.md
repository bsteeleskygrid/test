# Animated Layout Demo

This project demonstrates the proxyTransform -> followTransform animated layout.
I start with a list of models.
Essentially I use the Unity auto-layout tools to calculate the ideal size and position of each item.
I then instantiate items that have an AnimateLayout and AnimatePosition script.
The result is that instead of instant updates to layout, your items will animate smoothly.
