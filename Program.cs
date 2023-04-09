using SLVP_OOVerden_Bestik;

Kniv kniv = new Kniv(12, "rustfrit stål", "elfenben", false);
kniv.Skære("steak");
kniv.Info();
kniv.Vasket();
kniv.Info();
Console.WriteLine();
Gaffel gaffel = new Gaffel(9, "plastik", "træ", 12);
gaffel.Stikke("kartoffel");
gaffel.Info();
gaffel.Vasket();
gaffel.Info();
Console.WriteLine();
Ske ske = new Ske(10, "jern", "plastik");
ske.Øse("aspargessuppe");
ske.Info();
ske.Vasket();
ske.Info();
