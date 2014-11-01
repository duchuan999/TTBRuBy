require 'test_helper'

class DmnoiscsControllerTest < ActionController::TestCase
  setup do
    @dmnoisc = dmnoiscs(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmnoiscs)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmnoisc" do
    assert_difference('Dmnoisc.count') do
      post :create, dmnoisc: { diachi: @dmnoisc.diachi, ma: @dmnoisc.ma, stt: @dmnoisc.stt, ten: @dmnoisc.ten }
    end

    assert_redirected_to dmnoisc_path(assigns(:dmnoisc))
  end

  test "should show dmnoisc" do
    get :show, id: @dmnoisc
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmnoisc
    assert_response :success
  end

  test "should update dmnoisc" do
    patch :update, id: @dmnoisc, dmnoisc: { diachi: @dmnoisc.diachi, ma: @dmnoisc.ma, stt: @dmnoisc.stt, ten: @dmnoisc.ten }
    assert_redirected_to dmnoisc_path(assigns(:dmnoisc))
  end

  test "should destroy dmnoisc" do
    assert_difference('Dmnoisc.count', -1) do
      delete :destroy, id: @dmnoisc
    end

    assert_redirected_to dmnoiscs_path
  end
end
