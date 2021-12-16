

async function login() {
	Moralis.initialize("P3t1SFapLDb3QVViHx5eKzRoZU0VG0j1XAzuqT8h"); // Application id from moralis.io
	Moralis.serverURL = "https://7vjalah5zsqb.usemoralis.com:2053/server"; //Server url from moralis.io
	console.log("login clicked");
	var user = await Moralis.Web3.authenticate();
	if (user) {
		console.log(user);
		console.log(user.id);
		//user.set("nickname", "VITALIK");
		//user.set("fav_color", "blue");
		//user.save();
	}
	return user.id;
}