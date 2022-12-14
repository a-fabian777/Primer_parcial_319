data()
data(iris)
head(iris)
summary(iris)
str(iris)
plot(x=iris$Petal.Length,y=iris$Petal.Width, col=iris$Species)
plot(iris$Petal.Length,iris$Petal.Width, pch=c(23,24,25)[unclass(iris$Species)],main="Iris Data")
plot(iris$Petal.Length,iris$Petal.Width, pch=c("red",24,25)[unclass(iris$Species)],main="Iris Data")
plot(iris$Petal.Length,iris$Petal.Width, pch=21, bg=c("red","green","blue")[unclass(iris$Species)],main="Iris Data")
pairs(iris[1:4], col=iris$Species,pch=21, bg=c("red","green","blue")[unclass(iris$Species)])
