<?

   function inWebSlice() {
   
      $http_a_im = isset($_SERVER['HTTP_A_IM'])?$_SERVER['HTTP_A_IM']:"";
      $http_user_agent = isset($_SERVER['HTTP_USER_AGENT'])?$_SERVER['HTTP_USER_AGENT']:"";
      $http_accept = isset($_SERVER['HTTP_ACCEPT'])?$_SERVER['HTTP_ACCEPT']:"";
      
      $slice_a_im = "feed";
      $slice_user_agent = "Windows-RSS-Platform";
      $slice_accept = "*/*";
      
      if($http_a_im == $slice_a_im &&
         substr($http_user_agent, 0, strlen($slice_user_agent)) == $slice_user_agent &&
         $http_accept == $slice_accept)
         return true;
      else return false;

   }

   function login() {

      session_start();

      $user   = 'demo';
      $pass   = 'demo';
      $submit = 'submit';
      
      $session_user = isset($_SESSION['user'])?$_SESSION['user']:"";
      $session_pass = isset($_SESSION['pass'])?$_SESSION['pass']:"";

      $post_user    = isset($_POST['user'])?$_POST['user']:""; 
      $post_pass    = isset($_POST['pass'])?$_POST['pass']:""; 
      $post_submit  = isset($_POST['submit'])?$_POST['submit']:""; 


      if($session_user == $user && $session_pass == $pass) {
         return true;
      } else if($post_submit == $submit) {
         if($post_user == $user && $post_pass == $pass) {
            $_SESSION['user']=$post_user;
            $_SESSION['pass']=$post_pass;
            return true;
         } else return false;
      } else return false;
   
   }

?>