﻿namespace BlazorApp1.Data
{
    public static class PizzaList
    {
        public static List<Pizza> pizzas = new List<Pizza>()
        {
            new Pizza("Пеперони", "Сочная и ароматная пицца \"Пеперони\" - это настоящий кулинарный шедевр! Каждый кусочек этой пиццы пропитан неповторимым вкусом специй, придающих блюду неповторимую пикантность.", 830, "Peperoni.jpg"),
            new Pizza("Гавайская","Гавайская пицца - это настоящий кулинарный оазис в океане вкусов! Каждый кусочек гавайской пиццы - это настоящее путешествие в мир вкусовых открытий, где сладость ананаса и солоноватость ветчины создают неповторимый вкусовой контраст.", 500,"Hawaii.jpg"),
            new Pizza("4 сыра","Пицца \"4 сыра\" - это истинное воплощение гастрономического рая на тарелке! Каждый кусочек этой пиццы - это настоящее кулинарное произведение искусства, которое погружает в мир изысканных вкусов и наслаждения.", 350,"4Cheese.jpg"),
            new Pizza("Ветчина и Грибы","Пицца \"Ветчина и Грибы\" - это настоящее воплощение гастрономического искусства. Погрузитесь в атмосферу итальянской страсти к кулинарии и насладитесь великолепием вкуса в каждой ломтике этой потрясающей пиццы!", 400,"VetchGribi.jpg"),
            new Pizza("Карбонара","Пицца \"Карбонара\" - страсть к итальянской кухне, где классическое блюдо \"Паста Карбонара\" превращается в шедевр пиццерийного искусства. Почувствуйте атмосферу Рима и великолепие вкуса в каждом кусочке этой потрясающей пиццы!", 600,"Carbonara.jpg"),
            new Pizza("Маргарита","Пицца \"Маргарита\" - это яркое солнце Италии, светящееся в каждом кусочке этого божественного блюда.\r\nКаждый укус пиццы \"Маргарита\" - это погружение в атмосферу средиземноморского рая, где простые ингредиенты превращаются в великолепное сочетание вкусов и ароматов.", 450,"Margarita.jpg")
        };
    }
}
