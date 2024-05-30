-> start

=== start ===
NPC: ¡Hola! ¿Cómo te va la vida?
* [Me va bien.]
    -> bien
* [Me va mal.]
    -> mal

=== bien ===
NPC: ¡Qué bien! Me alegra escuchar eso. Siempre es bueno saber que las cosas van bien.
-> despedida

=== mal ===
NPC: Lo siento mucho. Espero que las cosas mejoren pronto. Si necesitas hablar, aquí estoy.
-> despedida

=== despedida ===
NPC: Bueno, tengo que irme ahora. ¡Cuídate!
-> END
