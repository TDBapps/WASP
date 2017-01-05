<?php

// get variable 'page' from URL
$wikipage = htmlspecialchars($_GET["p"]);

// Security, remove all special characters except A-Z, a-z, 0-9, dots, hyphens, underscore before interpreting something. 
$wikipage = preg_replace('/[^A-Za-z0-9\._-]/', '', $wikipage);

  if(isset($_GET['page']))
  {
    // page found
  }else{
    // no page found, we propose fallback homepage Home.md
    $wikipage = "Home";
  }

// add library to parse markdown Github files
include(parsedown.php');

// display content main page
      $contents = file_get_contents('../../WASP.wiki.git/'. $wikipage .'.md');
      $Parsedown = new Parsedown();
      echo $Parsedown->text($contents);
      
            // dynamic menu generation from a folder
    
              # we scan all markdown in folder
              $search = glob("../../WASP.wiki.git/*.md");

              # we loop on found files
              if (!empty($search)){ 
                foreach ($search as $wikifile) {
                  
                  // clean path to filename only
                  $wikifile = basename($wikifile);
                  
                  // _Footer and _Sidebar are special page, they start with '_' exclude them
                  if (substr($wikifile, 0, 1) === '_') {
                    // page starting with '_' found, do nothing.
                  } else {
                    // Check if the page is Home, we don't display it here to keep it hardcoded on the top
                    if ($wikifile === 'Home.md') {
                    // Home.md found, do nothing
                    } else {
                      // Finally! we have a valid markdown page
                      // Clean filename to get only name without extension :
                      $wikifile = preg_replace('/\\.[^.\\s]{2,4}$/', '', $wikifile);
                      // Is there a chance we display the page of this button now? time to set status actif!
                      if ($wikifile === $wikipage) {
                      }
                      // Ok, we have all, diplay this button now :
                        echo '$wikipage';
                    }
                  }
                }
              }
          ?>
