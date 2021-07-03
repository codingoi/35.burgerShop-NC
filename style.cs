/* Universal Styles */

body {
  background-image: url("https://content.codecademy.com/courses/web-101/unit-6/htmlcss1-img_foodlogo.png");
  text-align: center;
  font-family: 'Roboto', sans-serif;
  font-size: 18px;
}

a {
  text-decoration: none;
}

/* Navigation */

nav {
  text-align: center;
}

nav img {
  display: block;
  width: 230px;
  margin: 20px auto;
}

nav div {
  width: 100%;
  background-color: #666;
  margin: 10px 0;
}

nav span {
  display: inline-block;
  font-size: 16px;
  font-weight: 100;
  letter-spacing: 2px;
  margin: 20px 0;

}

nav a {
  color: #FFF;
  font-weight: bold;
  margin: 0 5px;
}

/* Content Container */

.content {
  width: 100%;
  height: 500px;
  margin: 10px auto;
  overflow: scroll;
}

/* Content Header */

.header {
  background-image: url("https://content.codecademy.com/courses/web-101/unit-6/htmlcss1-img_burgerphoto.jpeg");
  background-position: center;
  background-size: cover;
  height: 320px;
}

.header h1 {
  background-color: #05A8AA;
  color: #FFF;
  font-family: 'Oswald', sans-serif;
  font-size: 40px;
  font-weight: 300;
  line-height: 40px;
  width: 68%;
  padding: 20px;
  margin: 0 auto;
}

/* Content Body */

.content .body {
  width: 100%;
  margin: 10px auto;
}

.body p {
  color: #333333;
  font-weight: 100;
  line-height: 34px;
  width: 90%;
  margin-top: 18px;
  margin: 20px auto;
}

/* Content Button */

.button {
  background-color: #05A8AA;
  color: #FFF;
  display: block;
  font-weight: 700;
  width: 200px;
  padding: 20px;
  margin: 40px auto;
}

.button:hover {
  background-color: #FFF;
  color: #05A8AA;
  border: 1px solid #05A8AA;
}

/* Content Nutrition */

ul.nutrition {
  padding: 20px;
}

ul.nutrition li {
  display: inline-block;
  background-color: #777;
  list-style: none;
  width: 90%;
  padding: 10px 10px;
  margin: 5px 10px;
}

.nutrition .category {
  color: white;
  font-weight: 100;
  letter-spacing: 2px;
  display: block;
}

.nutrition .value {
  color: white;
  font-size: 26px;
  font-weight: 700;
  letter-spacing: 2px;
  margin: auto 0;

}
