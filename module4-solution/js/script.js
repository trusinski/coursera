(function() {
    var names = ["Yaakov", "John", "Jen", "Jason", "Paul", "Frank", "Larry", "Paula", "Laura", "Jim"];
    // STEP 10:
    // Loop over the names array and say either 'Hello' or "Good Bye"
    // using either the helloSpeaker's or byeSpeaker's 'speak' method.
    // See Lecture 50, part 1
    for (var name in names) {
        
      // STEP 11:
      // Retrieve the first letter of the current name in the loop.
      // Use the string object's 'charAt' function. Since we are looking for
      // names that start with either upper case or lower case 'J'/'j', call
      // string object's 'toLowerCase' method on the result so we can compare
      // to lower case character 'j' afterwards.
      // Look up these methods on Mozilla Developer Network web site if needed.
      var firstLetter = names[name].toLowerCase().charAt(0);
       
      // STEP 12:
      // Compare the 'firstLetter' retrieved in STEP 11 to lower case
      // 'j'. If the same, call byeSpeaker's 'speak' method with the current name
      // in the loop. Otherwise, call helloSpeaker's 'speak' method with the current
      // name in the loop.

      if (firstLetter === "j") {
        byeSpeaker.speak(names[name]);
      } else {
        helloSpeaker.speak(names[name]);
      }
    }
})();
