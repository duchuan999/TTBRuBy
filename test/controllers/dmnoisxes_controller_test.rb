require 'test_helper'

class DmnoisxesControllerTest < ActionController::TestCase
  setup do
    @dmnoisx = dmnoisxes(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmnoisces)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmnoisx" do
    assert_difference('Dmnoisc.count') do
      post :create, dmnoisx: { diachi: @dmnoisx.diachi, ma: @dmnoisx.ma, stt: @dmnoisx.stt, ten: @dmnoisx.ten }
    end

    assert_redirected_to dmnoisx_path(assigns(:dmnoisx))
  end

  test "should show dmnoisx" do
    get :show, id: @dmnoisx
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmnoisx
    assert_response :success
  end

  test "should update dmnoisx" do
    patch :update, id: @dmnoisx, dmnoisx: { diachi: @dmnoisx.diachi, ma: @dmnoisx.ma, stt: @dmnoisx.stt, ten: @dmnoisx.ten }
    assert_redirected_to dmnoisx_path(assigns(:dmnoisx))
  end

  test "should destroy dmnoisx" do
    assert_difference('Dmnoisc.count', -1) do
      delete :destroy, id: @dmnoisx
    end

    assert_redirected_to dmnoisxes_path
  end
end
